using BasicManage.Entities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Reflection;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using NPOI.HSSF.UserModel;
using System.Data;

namespace BasicManage.Tool
{
    public class PublicUtil
    {
        public PublicUtil()
        {

        }
        /// <summary>
        /// 检查登录状态
        /// </summary>
        /// <returns>是否存在</returns>
        public bool CheckLoginState()
        {
            if (string.IsNullOrEmpty(UserInfo.GetInstance().UserId))
                return false;
            else
                return true;
        }
        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj">将要序列化的对象</param>
        /// <returns>序列化后的json字符串</returns>
        public string GetJsonData(Object obj)
        {
            string json = "";
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss" };
            json = JsonConvert.SerializeObject(obj, Formatting.Indented, timeConverter);
            json = Regex.Replace(json, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
            });
            return json;
        }
        /// <summary>
        /// 权限校验
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <returns>是否具有请求地址的权限</returns>
        public bool CheckPower(string url, MyDBContext mdb)
        {
            if (!CheckLoginState())
                return false;
            string usertype = UserInfo.GetInstance().UserType;
            string roletype = UserInfo.GetInstance().RoleType;
            List<v_getuserpower> powerlist = mdb.v_getuserpower.Where(u => u.RoleId.Equals(roletype) && u.NodeType.Equals("0")).ToList();
            if (usertype.Equals("1"))
            {
                List<v_getuserpower> tmplist = mdb.v_getuserpower.Where(u => u.NodeType.Equals("1")).ToList();
                if (powerlist == null)
                    powerlist = tmplist;
                else
                    powerlist.AddRange(tmplist);
            }
            powerlist = powerlist.OrderBy(u => u.NodeNum).ToList();
            foreach (v_getuserpower item in powerlist)
            {
                if (url.Contains(item.NodeUrl) && !string.IsNullOrWhiteSpace(url) && !string.IsNullOrWhiteSpace(item.NodeUrl))
                    return true;
            }
            return false;
        }
        public string GetIpAddress(string ip)
        {
            string backMsg = "";
            try
            {
                System.Net.WebRequest httpRquest = System.Net.HttpWebRequest.Create(@"http://whois.pconline.com.cn/ip.jsp?ip=" + ip);
                httpRquest.Method = "GET";
                //这行代码很关键，不设置ContentType将导致后台参数获取不到值  
                //httpRquest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
                System.Net.WebResponse response = httpRquest.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(responseStream, System.Text.Encoding.GetEncoding("GB2312"));
                backMsg = reader.ReadToEnd().Trim();
                reader.Close();
                reader.Dispose();
                responseStream.Close();
                responseStream.Dispose();
            }
            catch (Exception ex)
            {
                Tool.LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
            }
            return backMsg;
        }
        /// <summary>
        /// 获取上传excel文件的内容，并转换成list<t>
        /// </summary>
        /// <typeparam name="T">要转换的类型</typeparam>
        /// <param name="excelFile">上传文件</param>
        /// <param name="sheetIndex">第几个表格，默认第0个</param>
        /// <returns></returns>
        public List<T> GetExcelToList<T>(IFormFile excelFile, int sheetIndex = 0)
        {
            List<T> list = new List<T>();
            IWorkbook workbook = null;
            using (MemoryStream ms = new MemoryStream())
            {
                excelFile.CopyTo(ms);
                ms.Seek(0, SeekOrigin.Begin);
                string ext = Path.GetExtension(excelFile.FileName);
                if (ext.Equals(".xls"))
                    workbook = new HSSFWorkbook(ms);
                else
                    workbook = new XSSFWorkbook(ms);
            }
            ISheet sheet = workbook.GetSheetAt(sheetIndex);
            IRow cellRow = sheet.GetRow(0);
            var propertys = typeof(T).GetProperties();
            int num = cellRow.LastCellNum;
            for (int i = sheet.FirstRowNum+1; i < sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null) continue;
                T obj = System.Activator.CreateInstance<T>();
                for (int j = row.FirstCellNum; j < num; j++)
                {
                    if (row.GetCell(j) == null) continue;
                    string value= GetCellValue(row.GetCell(j));
                    string propertyStr = (propertys[j].PropertyType).FullName;
                    switch (propertyStr)
                    {
                        case "System.String":
                            propertys[j].SetValue(obj, value, null);
                            break;
                        case "System.DateTime":
                            DateTime pdt = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                            propertys[j].SetValue(obj, pdt, null);
                            break;
                        case "System.Boolean":
                            bool pb = Convert.ToBoolean(value);
                            propertys[j].SetValue(obj, pb, null);
                            break;
                        case "System.Int32":
                            int pi32 = Convert.ToInt32(value);
                            propertys[j].SetValue(obj, pi32, null);
                            break;
                        default:
                            break;
                    }
                }
                list.Add(obj);
            }
            return list;
        }
        public string GetCellValue(ICell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }
            switch (cell.CellType)
            {
                case CellType.String:
                    return cell.StringCellValue;

                case CellType.Formula:
                    {
                        try
                        {
                            new HSSFFormulaEvaluator(cell.Sheet.Workbook).EvaluateInCell(cell);
                            return cell.ToString();
                        }
                        catch
                        {
                            return cell.NumericCellValue.ToString();
                        }
                    }
                case CellType.Blank:
                    return string.Empty;

                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();

                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
            }
            return cell.ToString();

        }
        /// <summary>
        /// 检查实体数据格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public string CheckEntityData<T>(T t)
        {
            Type tp = typeof(T);
            PropertyInfo[] properties = typeof(T).GetProperties();
            string remarks = string.Empty;
            bool flag = false;
            for (int i = 0; i < properties.Length; i++)
            {
                object[] attr1 = properties[i].GetCustomAttributes(true);
                foreach (object item in attr1)
                {
                    RequiredAttribute requiredAttribute = item as RequiredAttribute;
                    if (requiredAttribute != null)
                    {
                        object checkvalue = properties[i].GetValue(t);
                        if (!requiredAttribute.IsValid(checkvalue))
                        {
                            remarks = requiredAttribute.ErrorMessage;
                            flag = true;
                            break;
                        }
                    }
                    RangeAttribute rangeAttribute = item as RangeAttribute;
                    if (rangeAttribute != null)
                    {
                        object checkvalue = properties[i].GetValue(t);
                        if (!rangeAttribute.IsValid(checkvalue))
                        {
                            remarks = rangeAttribute.ErrorMessage;
                            flag = true;
                            break;
                        }
                    }
                    RegularExpressionAttribute regularExpressionAttribute = item as RegularExpressionAttribute;
                    if (regularExpressionAttribute != null)
                    {
                        object checkvalue = properties[i].GetValue(t);
                        if (!regularExpressionAttribute.IsValid(checkvalue))
                        {
                            remarks = regularExpressionAttribute.ErrorMessage;
                            flag = true;
                            break;
                        }
                    }
                    DataTypeAttribute dataTypeAttribute = item as DataTypeAttribute;
                    if (dataTypeAttribute != null)
                    {
                        object checkvalue = properties[i].GetValue(t);
                        if (!dataTypeAttribute.IsValid(checkvalue))
                        {
                            remarks = dataTypeAttribute.ErrorMessage;
                            flag = true;
                            break;
                        }
                    }
                    MaxLengthAttribute maxLengthAttribute = item as MaxLengthAttribute;
                    if(maxLengthAttribute != null)
                    {
                        object checkvalue = properties[i].GetValue(t);
                        if (!maxLengthAttribute.IsValid(checkvalue))
                        {
                            remarks = maxLengthAttribute.ErrorMessage;
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag)
                    break;
            }
            return remarks;
        }
    }
}