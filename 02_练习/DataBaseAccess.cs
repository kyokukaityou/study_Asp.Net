 public String connsql = "Data Source=(localdb)\\ProjectsV12;Initial Catalog=ComHome;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public SqlConnection conn;

        public void DBConnection() {
            conn = new SqlConnection(connsql);
        }

        public DataTable SqlQuery(String sql) {

            DataTable dt = new DataTable();

            conn.Open();

            SqlDataAdapter myda = new SqlDataAdapter("SELECT * FROM Company", conn);

            myda.Fill(dt);

            conn.Close();

            return dt;
        }

        public void CloseConnection() {
            if (conn != null) {
                conn.Close();
            }
        }
