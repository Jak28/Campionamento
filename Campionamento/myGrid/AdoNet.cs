using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace myGrid
{
    public class AdoNet
    {
        private static string cnString;
        public OleDbConnection cn;
        public OleDbCommand cmd;
        public OleDbDataAdapter adp;
        public DataTable daTable;   //disconnesso
        public OleDbDataReader reader;  //connesso in sola lettura al DB

        public static void impostaConessione(string dbName)
        {
            if (dbName != "")
            {
                if (System.IO.Path.GetExtension(dbName).Equals(".mdb"))

                    cnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbName;
                else
                    cnString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + dbName;
            }
        }

        //prima di chiamare init bisogna impostare la connectionString
        private void init()
        {
            if (cnString != "")
            {
                cn = new OleDbConnection();
                cn.ConnectionString = cnString;
                cmd = new OleDbCommand();
                cmd.Connection = cn;
                adp = new OleDbDataAdapter(cmd);
                adp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                daTable = new DataTable();
            }
            else
                throw new Exception("ConnectionString not inizialized");
        }

        public AdoNet()
        {
            init();
        }

        public AdoNet(string dbName)
        {
            impostaConessione(dbName);
            init();
        }

        public void apriConnessione()
        {
            if (cn != null && cn.ConnectionString != "" && cn.State == ConnectionState.Closed)
                cn.Open();
        }

        public void chiudiConnessione()
        {
            if (cn != null && cn.ConnectionString != "" && cn.State == ConnectionState.Open)
                cn.Close();
        }

        /// <summary>
        /// esegue le query tabellari(restituiscono una tabella)
        /// </summary>
        /// <param name="sql">Testo della query</param>
        /// <param name="tipo">Tipo della query Text/StoredProcedure</param>
        public void eseguiQuery(string sql, CommandType tipo)
        {
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            if (daTable.IsInitialized)
                daTable.Clear();
            adp.Fill(daTable);  //apre la connessione automaticamente e carica i dati
        }

        /// <summary>
        /// esegue le query scalari(restituiscono un risultato secco)
        /// </summary>
        /// <param name="sql">Testo della query</param>
        /// <param name="tipo">Text/StoredProcedure</param>
        /// <returns>restituisce una stringa con il risultato</returns>
        public string eseguiScalar(string sql, CommandType tipo)
        {
            Object obj;
            string ris = string.Empty;
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            obj = cmd.ExecuteScalar();
            ris = obj.ToString();
            chiudiConnessione();
            return ris;
        }

        /// <summary>
        /// esegue comando DML/DDL(inserimento, eliminazione)
        /// </summary>
        /// <param name="sql">Testo della query</param>
        /// <param name="tipo">Text/StoredProcedure</param>
        /// <returns>restituisce il numero di record modificati</returns>
        public int eseguiNonQuery(string sql, CommandType tipo)
        {
            int ris = -1;
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            ris = cmd.ExecuteNonQuery();
            chiudiConnessione();
            return ris;
        }

        /// <summary>
        /// istanzia un oggetto dataReader connesso al DB
        /// </summary>
        /// <param name="sql">Testo dell query</param>
        /// <param name="tipo">Text/StoredProcedure</param>
        /// <returns>Restituisce l'oggetto istanziato</returns>
        public OleDbDataReader creaLettore(string sql, CommandType tipo)
        {
            cmd.CommandText = sql;
            cmd.CommandType = tipo;
            apriConnessione();
            reader = cmd.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// deistanzia il dataReader
        /// </summary>
        public void chiudiLettore()
        {
            chiudiConnessione();
            reader.Dispose();
        }

        public void dispose()
        {
            if (adp != null) adp.Dispose();
            if (cmd != null) cmd.Dispose();
            if (cn != null) cn.Dispose();
        }
    }
}
