using LanguageConsult.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseLanguageWinForm.DataLibaryAccess
{
    internal static class DataControlSingleton
    {
        private static DataAccess dataAccessLayer = null;

        public static DataAccess GetDataAccess()
        {
            if(dataAccessLayer == null)
            {
                GenerateDataAccess();
            }
            return dataAccessLayer;
        }

        private static void GenerateDataAccess()
        {
            DataAccessProvider prov = new DataAccessProvider();
            dataAccessLayer = prov.GetLiveDataAccess();
        }

    }
}
