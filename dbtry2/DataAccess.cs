using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Dapper;


namespace dbtry2
{
    public class DataAccess
    {


        public List<Person> GetPeople(string lName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Conhelper.conString("UsersDb")))
            {

                // var pplRetrieved = connection.Query<Person>($"Select * from Users where lName = '{lName}' ").ToList();

                var pplRetrieved = connection.Query<Person>("dbo.Users_GetBylName @lastName", new { lastName = lName }).ToList();

                return pplRetrieved;
            }
            // throw  new NotImplementedException();
        }

        public void insertPerson(string Username,/*string Id,*/ string FirstName, string lastName, string passworD, string emaiL)//oreder of inserting in db
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Conhelper.conString("UsersDb")))
            {
                // Person newPerson = new Person {Id=id,username=username,firstname=fName,lastname=lName,Emaila=email,PasworD=password };

                List<Person> People = new List<Person>();
                People.Add(new Person { username = Username,/* id = Id,*/ fName = FirstName, lName = lastName, password = passworD, email = emaiL });

                connection.Execute("dbo.Users_InsertPeople @username,@fName,@lName,@email,@password", People);
            }
            // throw new NotImplementedException();
        }

        public List<Person> GetALLPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Conhelper.conString("UsersDb")))
            {
                var AllpplRetrieved = connection.Query<Person>($"Select * from Users").ToList();

                return AllpplRetrieved;
            }
            //throw new NotImplementedException();
        }

        public List<Person> DeletePerson(string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Conhelper.conString("UsersDb")))
            {
                var personDeleted = connection.Query<Person>("dbo.Users_DeleteBylEmail @emaile", new { emaile = email }).ToList();

                return personDeleted;
            }
            //throw new NotImplementedException();
        }

        public List<Person> EditPerson(string Id, string Username, string FirstName, string lastName, string email, string passworD)
        {
           //throw new NotImplementedException();//

            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(Conhelper.conString("UsersDb")))
            {

              var  updatePerson = connection.Query<Person>("dbo.Users_UpdateByID @Idy,@username_,@fName,@lName,@email,@pwd", new { Idy = Id,
                  username_= Username,fName=FirstName,lName=lastName,email=email,pwd=passworD  }).ToList();
                return updatePerson;
            }
        }
    }
}
