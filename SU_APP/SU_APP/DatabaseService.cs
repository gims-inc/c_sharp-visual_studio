using System;
using System.Data.SqlClient;

namespace SSC
{
    /// <summary>
    /// Represents an access point to the database. Provides methods to read and write data from and to database.
    /// </summary>
    internal class DatabaseService
    {
        private readonly string _connectionString;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseService"/> class. If connection string is not provided
        /// then a default one is used.
        /// </summary>
        /// <param name="connectionString">The connection string that is used to establish connection with database.</param>
        public DatabaseService(string connectionString = null)
        {
            // Temporary solution with hardcoded connection string. The connection string should only be provided to the service.
            _connectionString = connectionString ?? @"Server=185.28.23.116; port=3306;Database=cainocok_sscApp;UId=cainocok;Password=#5*UTO7h5a5Oha;";
           // _connectionString = connectionString ?? @"Data Source=192.168.8.80,1234;User ID=sa;Password=sunami;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        /// <summary>
        /// Reads the user with given name from the database.
        /// </summary>
        /// <param name="name">The name of the user to read.</param>
        /// <returns>The <see cref="User"/> object.</returns>
        /// <exception cref="ArgumentNullException">Thrown in <see cref="name"/> parameter is null or empty string.</exception>
        /// <exception cref="Exception">Thrown in any unexpected situation.</exception>
        public User ReadUserByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                // NOTE! Still not good because Sql injection possible in 'name' parameter.
                using (var command = new SqlCommand(string.Format(Commands.SelectUserByName, name), connection))
                using (var commandReader = command.ExecuteReader())
                {
                    User user = null;
                    
                    if (commandReader.Read())
                        user = new User(commandReader["name"].ToString(), commandReader["password"].ToString());
                    if (commandReader.Read())
                        throw new Exception("More then one row retrieved.");
                    
                    commandReader.Close();
                    
                    return user;
                }
            }
        }
        
        public Controller InsertDetails(string imei,string version,string typeOftest,int signalStrength,float airtime,string controllerPhone,string manufacturer, string simOperator,DateTime dateCreated,string trac,string comments)
        {
       
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
              
               // throw new ArgumentException("Success!");
                // NOTE! Still not good because Sql injection possible in 'name' parameter.
                using (var command = new SqlCommand(string.Format(Commands.InsertControllerDetails, imei, version, typeOftest, signalStrength, airtime, controllerPhone,manufacturer, simOperator, dateCreated, trac,comments), connection))
                {
                    Controller controller = new Controller(imei, version, typeOftest, signalStrength, airtime, controllerPhone, manufacturer, simOperator, dateCreated, trac, comments);
                    var con = command.ExecuteNonQuery();
                    connection.Close();
                    return controller;
                }
            }
        }
      
        public int CountRepairedControllers()
        {
            int countedNumber=0;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(string.Format(Commands.SelectRepairedControllers), connection))
                using (var commandReader = command.ExecuteReader())
                {


                    if (commandReader.Read())
                    {
                        countedNumber = Int16.Parse(commandReader["oldControllers"].ToString());
                        
                    }
                    commandReader.Close();

                   
                }
            }
            return countedNumber;
        }
        public int CountNewControllers()
        {
            int countedNumber=0;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(string.Format(Commands.SelectNewControllers), connection))
                using (var commandReader = command.ExecuteReader())
                {


                    if (commandReader.Read())
                    {
                        countedNumber = Int16.Parse(commandReader["newControllers"].ToString());

                    }
                    commandReader.Close();


                }
            }
            return countedNumber;

        }
        public string notif;
        public Orders selectOrders(string userName, int numberOfControllers, string orderDate, string dueDate, string batchCode)
        {
            
            using (var connection = new SqlConnection(_connectionString))
            {
                Orders findOrder = null;
                connection.Open();
                using (var command = new SqlCommand(string.Format(Commands.SelectNotification), connection))
                using (var commandReader = command.ExecuteReader())
                {
                    

                    while (commandReader.Read())
                    {
                       
                        findOrder = new Orders(commandReader["by_who"].ToString(),  Int16.Parse(commandReader["number"].ToString()),  commandReader["dat"].ToString(), commandReader["due_date"].ToString(), commandReader["batch_code"].ToString());
                        string notf = findOrder.UserName + " made an order of " + findOrder.NumberOfControllers + " controllers on " + findOrder.OrderDate + ". Due date is on " + findOrder.DueDate + ". Batch code: " + findOrder.BatchCode + ". Status: Pending";
                        notif = notif + Environment.NewLine + Environment.NewLine + notf;
                    }
                    commandReader.Close();
                    return findOrder;
                   


                }
            }
            
        }

        public string CountAllNotifications(string countedNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(string.Format(Commands.CountNotification), connection))
                using (var commandReader = command.ExecuteReader())
                {


                    if (commandReader.Read())
                    {
                        countedNumber = commandReader["countedNotifications"].ToString();

                    }
                    commandReader.Close();


                }
            }
            return countedNumber;

        }
        SqlDataAdapter datat = new SqlDataAdapter();
        public SqlDataAdapter SelectAllControllers(string data)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // throw new ArgumentException("Success!");
                // NOTE! Still not good because Sql injection possible in 'name' parameter.
                using (var command = new SqlCommand(string.Format(Commands.SelectControllers), connection))
                {
                    SqlDataAdapter tableData = new SqlDataAdapter();
                    tableData.SelectCommand = command;
                   
                    connection.Close();
                    return tableData;
                }
               
            }
        }

        public string FilterString(string filter)
        {
            string filterString = Commands.FilterController;
            return filterString;
        }
        private static class Commands
        {
            public const string SelectUserByName = "SELECT name, password FROM lognTable WHERE CONVERT(VARCHAR, name) = '{0}'";
            public const string InsertControllerDetails = "INSERT INTO dataTable(IMEI,Cversion,type,signall,Airtime,Gversion,manufacturer,operator,created,track,comment) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
            public const string SelectRepairedControllers = "Select count(*) as 'oldControllers' from dataTable where type='Subsequent'";
            public const string SelectNewControllers = "Select count(*) as 'newControllers' from dataTable where type='First time'";
            public const string SelectNotification = "Select* from orderTable where status='pending'";
            public const string CountNotification = "Select count(*) as 'countedNotifications' from orderTable where status='pending'";
            public const string SelectControllers = "Select* from dataTable";
            public const string FilterController = "IMEI LIKE'%{0}%'";
        }
    }

    /// <summary>
    /// Represents user's data stored in database.
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class with given name and password.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        /// <param name="password">The password of the user.</param>
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
        
        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Sets the password of the user.
        /// </summary>
        public string Password { get; }
       
    }
    internal class Controller
    {
        //Initializes a new instance of controller details insert
        public Controller(string imei, string version, string typeOftest, int signalStrength, float airtime, string controllerPhone, string manufacturer, string simOperator, DateTime dateCreated, string trac, string comments)
        {
            Imei = imei;
            Version = version;
            TypeOftest = typeOftest;
            SignalStrength = signalStrength;
            Airtime = airtime;
            ControllerPhone = controllerPhone;
            Manufacturer = manufacturer;
            SimOperator = simOperator;
            DateCreated = dateCreated;
            Trac = trac;
            Comments = comments;
        }

        /// <summary>
        /// Sets the IMEI of the controller.
        /// </summary>
        public string Imei { get; }
        /// <summary>
        /// Sets the name of the user.
        /// </summary>
        public string Version{ get; }
        public string TypeOftest { get; }
        public int SignalStrength { get; }
        public float Airtime { get; }
        public string ControllerPhone { get; }
        public string Manufacturer { get; }
        public string SimOperator { get; }
        public DateTime DateCreated { get; }
        public string Trac { get; }
        public string Comments { get; }


    }
    internal class Orders
    {

    public Orders(string userName,int numberOfControllers, string orderDate, string dueDate, string batchCode)
    {
            UserName = userName;
            NumberOfControllers = numberOfControllers;
            OrderDate = orderDate;
            DueDate = dueDate;
            BatchCode = batchCode;
            
    }
        public string UserName { get; }
        public int NumberOfControllers { get; }
        public string OrderDate { get; }
        public string DueDate{ get; }
        public string BatchCode { get; }

    }
}