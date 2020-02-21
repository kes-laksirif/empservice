using System;
using System.Data;
using System.Collections.Generic;

namespace empservice.Models {
    public class EmpDataContext: IDisposable {

        private IDbConnection dbConnection;

        

        public void Dispose()
        {
            if (dbConnection != null)
            {
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
    }
}