// 受取パラメータの取得
String id = "";
if (HttpContext.Current.Request.QueryString[NewsTable.ID] != null)
{
  id = HttpContext.Current.Request.QueryString[NewsTable.ID].ToString();
}

// データの取得
DBTable dbt = new DBTable();
// 企業情報
DataTable company = dbt.Ns_company;
this.company_tel.InnerText = company.Rows[0][CompanyTable.TEL].ToString();
this.company_fax.InnerText = company.Rows[0][CompanyTable.FAX].ToString();
this.company_adress.InnerText = company.Rows[0][CompanyTable.ADDRESS].ToString();
this.company_mail.InnerText = company.Rows[0][CompanyTable.MAIL].ToString();
// 行データ取得
DataRow dr = dbt.GetDataRow(dbt.Ns_news, id);
this.title.InnerText = dr[NewsTable.TITLE].ToString();
this.content.InnerHtml = dr[NewsTable.CONTENT].ToString();



 this.content.InnerHtml = "<img src=\"image/" + activityImg + "\" width=\"500\" height=\"300\"/>";
