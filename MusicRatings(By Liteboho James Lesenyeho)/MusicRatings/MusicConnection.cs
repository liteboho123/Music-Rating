using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms; // using a windows-form format //


namespace MusicRatings
{
    class MusicConnection
    {
        public SqlConnection MyMusic = new SqlConnection("Data Source=(local);Initial Catalog=Music;Integrated Security=True"); // connecting or linking to the designated database //
        public SqlCommand cmd = null; // creating a command that the SQL must perform //
        public DataTable tbl; // creating a data-table //
        public SqlDataReader reader; //creating a reader for analysing data within SQL //
        public DataRow row; // creating data - rows //   
        
        public void GetMusic()
        {
            // create a data-table //

            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the database allocated // 
            cmd = new SqlCommand("select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating as [Rating out of 7], t.Song as Track, t.Year as [Year Established] from Artist a inner join Genre g on a.GenreID = g.ID join Track t on a.ID = t.ArtistID ", MyMusic); //*refreshens the command* *creating a link to the designated datasource*//
            reader = cmd.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = tbl.NewRow(); //Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i]; // the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//               
                
            }
            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//
           
        }

        public void GetGenre(string GenreType) //*Adding parameters within the method which are later referred to*//
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("Insert into Genre values('" + GenreType + "')  ", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SelectGenre()
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the database allocated // 
            cmd = new SqlCommand("select ID, GenreType as [Genre] from  Genre", MyMusic); //*refreshens the command* *creating a link to the designated datasource*//
            reader = cmd.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//Adds the numbers of rows that were read in the datatable//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read())//While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//

            }
            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void UpdateGenre(string GenreType, int ID)
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database //
            cmd = new SqlCommand("update Genre set GenreType = '" + GenreType + "' where ID = " + ID + "", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*// 
            cmd.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Complete Successfully");
        }

        public void GetArtist(string ArtistName, int GenreID)
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database //
            cmd = new SqlCommand("Insert into Artist values('" + ArtistName + "','" + GenreID + "')", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*// 

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SelectArtist()
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the database allocated // 
            cmd = new SqlCommand("select ID, ArtistName as [Artist Name] from Artist", MyMusic); //*refreshens the command* *creating a link to the designated datasource*//
            reader = cmd.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i)); //Adds the number of columns read to the datatable//
            }

            while (reader.Read())//While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//

            }
            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void UpdateArtist(string ArtistName, int ID)
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database //
            cmd = new SqlCommand("update Artist set ArtistName = '" + ArtistName + "' where ID = " + ID + "", MyMusic);
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*// 
            cmd.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Complete Successfully");
        }

        public void GetTrack(string Track, int Rating, int ArtistID)
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database //
            cmd = new SqlCommand("Insert into Track values('" + Rating + "','" + Track + "','','" + ArtistID + "')", MyMusic);
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//  

            MessageBox.Show("Record has been inserted in successfully"); //*before creating a messagebox, evaluate whether this class can operate on a windows form-based or not*// 
        }

        public void SelectTrack()
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the database allocated // 
            cmd = new SqlCommand("select ID, Song as Track from Track", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            reader = cmd.ExecuteReader(); //Executing the reader//



            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }

            while (reader.Read()) //While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//

            }
            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close(); //*postphone the reader and use it for future reference*//
            cmd.Dispose(); //*permenetally erase the SQL-command*//
        }

        public void UpdateTrack(string song, int Rating, int YearR, int ID)
        {
            MyMusic.Open(); // The SQL connection is reference to the designated database //
            cmd = new SqlCommand("update Track set Rating = '" + Rating + "', Song = '" + song + "', [Year] = '" + YearR + "'  where ID = " + ID + "", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            cmd.ExecuteNonQuery(); //*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*// 
            cmd.Dispose(); //*permenetally erase the SQL-command*//

            MessageBox.Show("Complete Successfully");
        }

        public void DeleteMusicRow(int ID)
        {
            MyMusic.Open();// The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("delete from Track delete from Artist delete from Genre where ID = '" + ID + "'", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            cmd.ExecuteNonQuery();//*executes the statement in the form of an SQL query*// 
            MyMusic.Close(); //*postphone the sqlconnection and use it later for future reference*//           
            cmd.Dispose(); //*permenetally erase the SQL-command*//

            
        }      

        public void GetCertainTrack(int ID)
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select * from Track where ID = " + ID + "", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            reader = cmd.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }
            while (reader.Read())//While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//
            }

            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close();//*postphone the reader and use it for future reference*//
            cmd.Dispose();//*permenetally erase the SQL-command*//
        }

        public void GetCertainArtist(int ID)
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select * from Artist where ID = " + ID + "", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            reader = cmd.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }
            while (reader.Read())//While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//
            }

            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close();//*postphone the reader and use it for future reference*//
            cmd.Dispose();//*permenetally erase the SQL-command*//
        }

        public void GetCertainGenre(int ID)
        {
            tbl = new DataTable(); // refreshens the table //
            MyMusic.Open(); // The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select * from Genre where ID = " + ID + "", MyMusic); //*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            reader = cmd.ExecuteReader(); //Executing the reader//

            for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
            {
                tbl.Columns.Add(reader.GetName(i));//Adds the number of columns read to the datatable//
            }
            while (reader.Read())//While the reader is being executed, do the following//
            {
                row = tbl.NewRow();//Adds a new row in the datatable//

                for (int i = 0; i < reader.FieldCount; i++)//when the 'for' loop method is executed, the reader should count the numbers of fields or columns stored inside the Database//
                {
                    row[i] = reader[i];// the newly created row is equivalent to the numbers of rows the reader has executed//
                }

                tbl.Rows.Add(row);//Adds the numbers of rows that were read to the datatable//
            }

            MyMusic.Close();//*postphone the sqlconnection and use it later for future reference*//
            reader.Close();//*postphone the reader and use it for future reference*//
            cmd.Dispose();//*permenetally erase the SQL-command*//
        }

        public void SearchArtist(string Artist)
        {
            tbl = new DataTable();// refreshens the table //
            MyMusic.Open();// The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating as [Rating out of 7], t.Song as Track, t.Year as [Year Established] from Artist a inner join Genre g on a.GenreID = g.ID join Track t on a.ID = t.ArtistID where a.ArtistName like '%" + Artist + "%'", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            SqlDataAdapter sda = new SqlDataAdapter();// creating an SQLDataAdapter for data to be exorted out from the database //
            sda.SelectCommand = cmd;//The SQLDataAdapter is executed when it is referring to the SQLcommand//
            sda.Fill(tbl);//The SQLDataAdapter filters the table after the command has been executed//          
 
        }

        public void SearchRating(int Rating)
        {

            tbl = new DataTable();// refreshens the table //
            MyMusic.Open();// The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating as [Rating out of 7], t.Song as Track, t.Year as [Year Established] from Artist a inner join Genre g on a.GenreID = g.ID join Track t on a.ID = t.ArtistID where t.Rating like '%" + Rating + "%'", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            SqlDataAdapter sda = new SqlDataAdapter(); // creating an SQLDataAdapter for data to be exorted out from the database //
            sda.SelectCommand = cmd;//The SQLDataAdapter is executed when it is referring to the SQLcommand//
            sda.Fill(tbl);//The SQLDataAdapter filters the table after the command has been executed//  
        }

        public void SearchSong(string Song)
        {

            tbl = new DataTable();// refreshens the table //
            MyMusic.Open();// The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating as [Rating out of 7], t.Song as Track, t.Year as [Year Established] from Artist a inner join Genre g on a.GenreID = g.ID join Track t on a.ID = t.ArtistID where t.Song like '%" + Song + "%'", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            SqlDataAdapter sda = new SqlDataAdapter();// creating an SQLDataAdapter for data to be exorted out from the database //
            sda.SelectCommand = cmd;//The SQLDataAdapter is executed when it is referring to the SQLcommand//
            sda.Fill(tbl);//The SQLDataAdapter filters the table after the command has been executed//  
        }

        public void SearchYear(int Year)
        {
            tbl = new DataTable();// refreshens the table //
            MyMusic.Open();// The SQL connection is reference to the designated database // 
            cmd = new SqlCommand("select a.ID, a.ArtistName as [Artist Name], g.GenreType as [Genre], t.Rating as [Rating out of 7], t.Song as Track, t.Year as [Year Established] from Artist a inner join Genre g on a.GenreID = g.ID join Track t on a.ID = t.ArtistID where t.Year like '%" + Year + "%'", MyMusic);//*The single qoutation marks /''/ and the commas /,/ represent that this whole statement is executed within the SQL database. "MyMusic" basically specifies the execution of the located database*//
            SqlDataAdapter sda = new SqlDataAdapter();// creating an SQLDataAdapter for data to be exorted out from the database //
            sda.SelectCommand = cmd;//The SQLDataAdapter is executed when it is referring to the SQLcommand//
            sda.Fill(tbl);//The SQLDataAdapter filters the table after the command has been executed//   
        }

    }
}
