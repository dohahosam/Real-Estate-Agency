using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace RSA
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        //this function gets the areas, I'll use it for a combobox-Asmaa-.
        public DataTable getAreas()
        {
            string StoredProcedureName = StoredProcedures.getAllAreas;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        //this function inserts an Employee(User then Employee)-Asmaa-
        public int InsertEmp(string Username, string email, string password, char privilege, int ssn, double rate, string fname, char minit, string lname, char gender, DateTime Bdate, int Phone, int salary, string MangerUser)
        {
            string storedProcedureName = StoredProcedures.InsertEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username); Parameters.Add("@EmailAddress", email); Parameters.Add("@Password", password);
            Parameters.Add("@Privilege", privilege); Parameters.Add("@SSN", ssn); Parameters.Add("@AverageRating", rate);
            Parameters.Add("@FName", fname); Parameters.Add("@Minit", minit); Parameters.Add("LName", lname); Parameters.Add("@Gender", gender);
            Parameters.Add("@Birthdate", Bdate); Parameters.Add("@Phone#", Phone); Parameters.Add("@salary", salary); Parameters.Add("@ManagerUser", MangerUser);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }

        //this function gets privileges -obviously-
        public DataTable getPrivilege()
        {
            string StoredProcedureName = StoredProcedures.getPrivileges;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


        //this function gets Managers -obviously-
        public DataTable getManager()
        {
            string StoredProcedureName = StoredProcedures.getManagers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        //this function gets an employee with a given username
        public DataTable getOneEmployee(string user)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", user);
            string StoredProcedureName = StoredProcedures.getEmployee;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //this function deletes Employee
        public int delEmployee(string user)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", user);
            string StoredProcedureName = StoredProcedures.deleteEmp;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //this function insert AreaAgent Relation
        public int insertAreaAgent(string user, int AreaID)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", user); Parameters.Add("@AreaID", AreaID);
            string StoredProcedureName = StoredProcedures.InsertAgentArea;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //this function insert AreaManager Relation
        public int insertAreaManager(string user, int AreaID)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", user); Parameters.Add("@AreaID", AreaID);
            string StoredProcedureName = StoredProcedures.InsertManagerArea;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //this function is to add a rating relation
        public int ratingAgent(string CustomerUser, string AgentUser, int rate, string RateDate)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustomerUser", CustomerUser); Parameters.Add("@AgentUser", AgentUser);
            Parameters.Add("@Rating", rate); Parameters.Add("@RatingDate", RateDate);
            string StoredProcedureName = StoredProcedures.RatingAgent;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //this function is to modify user'w average rating
        public int CalAvgRating(string AgentUser, double AvgRating)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AvgRating", AvgRating); Parameters.Add("@AgentUser", AgentUser);
            string StoredProcedureName = StoredProcedures.calAvgRating;
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //this function gets employee user name by the mean of their number
        public DataTable agentByPhone(int phoneNo)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@phone#", phoneNo);
            string StoredProcedureName = StoredProcedures.AgentByPhone;
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //this function counts the ratings of a given user
        public object rateSum(string AgentUser)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AgentUsername", AgentUser);
            string StoredProcedureName = StoredProcedures.RateSum;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }
        //this function gets the same of all previous ratings
        public object rateCount(string AgentUser)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AgentUsername", AgentUser);
            string StoredProcedureName = StoredProcedures.RateCount;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        //Query the DB to check for username/password
        public object login(string Username, string Password)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username); Parameters.Add("@Password", Password);
            string StoredProcedureName = StoredProcedures.Login;
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }
        public int insertHouse(int HousingNo, string OwnerUsername, int AreaID, int Availibilty, string Address, char RentersGender, int Price, int NoOfBeds, int NoOfRooms, int RentDuration, int Furnished, string RentalType, int NaturalGas, int InternetConnection, int AirConditioned, string Extra)
        {
            string storedProcedureName = StoredProcedures.InsertHouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", HousingNo);
            Parameters.Add("@OwnerUsername", OwnerUsername); Parameters.Add("@AreaID", AreaID); Parameters.Add("@Availibilty", Availibilty);
            Parameters.Add("@Address", Address); Parameters.Add("@RentersGender", RentersGender); Parameters.Add("@Price", Price);
            Parameters.Add("@NoOfBeds", NoOfBeds); Parameters.Add("@NoOfRooms", NoOfRooms); Parameters.Add("@RentDuration", RentDuration);
            Parameters.Add("@Furnished", Furnished); Parameters.Add("@RentalType", RentalType); Parameters.Add("@NaturalGas", NaturalGas); Parameters.Add("@InternetConnection", InternetConnection); Parameters.Add("@AirConditioned", AirConditioned); Parameters.Add("@Extra", Extra);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public int InsertRoom(int HousingNo, string OwnerUsername, int AreaID, int Availibilty, string Address, char RentersGender, int Price, int NoOfBeds, int NoOfRooms, int RentDuration, int Furnished, string RentalType, int NaturalGas, int InternetConnection, int AirConditioned, string Extra, int RoomNo, int RAvailibilty, int RNoOfBeds, int Rprice)
        {
            string storedProcedureName = StoredProcedures.InsertRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", HousingNo); Parameters.Add("@Room#", RoomNo); Parameters.Add("@@RAvailibiluty", RAvailibilty); Parameters.Add("@RNumberOfBeds", RNoOfBeds); Parameters.Add("@RPrice", Rprice);
            Parameters.Add("@OwnerUsername", OwnerUsername); Parameters.Add("@AreaID", AreaID); Parameters.Add("@Availibilty", Availibilty);
            Parameters.Add("@Address", Address); Parameters.Add("@RentersGender", RentersGender); Parameters.Add("@Price", Price);
            Parameters.Add("@NoOfBeds", NoOfBeds); Parameters.Add("@NoOfRooms", NoOfRooms); Parameters.Add("@RentDuration", RentDuration);
            Parameters.Add("@Furnished", Furnished); Parameters.Add("@RentalType", RentalType); Parameters.Add("@NaturalGas", NaturalGas); Parameters.Add("@InternetConnection", InternetConnection); Parameters.Add("@AirConditioned", AirConditioned); Parameters.Add("@Extra", Extra);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public int InsertBed(int HousingNo, string OwnerUsername, int AreaID, int Availibilty, string Address, char RentersGender, int Price, int NoOfBeds, int NoOfRooms, int RentDuration, int Furnished, string RentalType, int NaturalGas, int InternetConnection, int AirConditioned, string Extra, int RoomNo, int RAvailibilty, int RNoOfBeds, int Rprice, int BAvailibilty, int BPrice)
        {
            string storedProcedureName = StoredProcedures.InsertBed;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", HousingNo); Parameters.Add("@Room#", RoomNo); Parameters.Add("@@RAvailibiluty", RAvailibilty); Parameters.Add("@RNumberOfBeds", RNoOfBeds); Parameters.Add("@RPrice", Rprice);
            Parameters.Add("@OwnerUsername", OwnerUsername); Parameters.Add("@AreaID", AreaID); Parameters.Add("@Availibilty", Availibilty);
            Parameters.Add("@Address", Address); Parameters.Add("@RentersGender", RentersGender); Parameters.Add("@Price", Price);
            Parameters.Add("@NoOfBeds", NoOfBeds); Parameters.Add("@NoOfRooms", NoOfRooms); Parameters.Add("@RentDuration", RentDuration);
            Parameters.Add("@Furnished", Furnished); Parameters.Add("@RentalType", RentalType); Parameters.Add("@NaturalGas", NaturalGas); Parameters.Add("@InternetConnection", InternetConnection); Parameters.Add("@AirConditioned", AirConditioned); Parameters.Add("@Extra", Extra);
            Parameters.Add("@BAvailibilty", BAvailibilty); Parameters.Add("@BPrice", BPrice);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public int CountHousing()
        {
            string StoredProcedureName = StoredProcedures.CountHousing;
            return dbMan.ExecuteNonQuery(StoredProcedureName, null);
        }
        public int CountRoom()
        {
            string StoredProcedureName = StoredProcedures.CountRoom;
            return dbMan.ExecuteNonQuery(StoredProcedureName, null);
        }

        //this function views all houses in certain location
        public DataTable ViewHouses(int areaID)
        {
            string storedProcedureName = StoredProcedures.ViewHouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AreaID", areaID);
            return dbMan.ExecuteReader(storedProcedureName, Parameters);

        }
        public int rentHouse(int Housing,DateTime RentalStartDate, string RenterUsername,DateTime RentalEndDate,int RentalPrice)
        {
            string storedProcedureName = StoredProcedures.RentHouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", Housing);
            Parameters.Add("@RentalStartDate", RentalStartDate);
            Parameters.Add("@RenterUsername", RenterUsername);
            Parameters.Add("@RentalEndDate", RentalEndDate);
            Parameters.Add("@RentalPrice", RentalPrice);

            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);

        }

        public int houseAvailability(int House)
        {
            string storedProcedureName = StoredProcedures.HouseAvailability;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", House);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public DataTable ViewRooms(int areaID)
        {
            string storedProcedureName = StoredProcedures.ViewRoom;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AreaID", areaID);
            return dbMan.ExecuteReader(storedProcedureName, Parameters);

        }
        public int rentRoom(int Housing, int Room,  DateTime RentalStartDate, DateTime RentalEndDate, string RenterUsername, int RentalPrice)
        {
            string storedProcedureName = StoredProcedures.RentHouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", Housing);
            Parameters.Add("@Room#", Room);
            Parameters.Add("@RentalStartDate", RentalStartDate);
            Parameters.Add("@RenterUsername", RenterUsername);
            Parameters.Add("@RentalEndDate", RentalEndDate);
            Parameters.Add("@RentalPrice", RentalPrice);

            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);

        }
        public int roomAvailability(int House, int Room)
        {
            string storedProcedureName = StoredProcedures.RoomAvailability;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Housing#", House);
            Parameters.Add("@Room#", Room);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public int AddNewCustomer(string Username, string EmailAddress, string Password, Char Privilege, string FName, Char MInit, string LName, Char Gender, DateTime BirthDate, int Phone)
        {
            string storedProcedureName = StoredProcedures.InsertHouse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username); Parameters.Add("@EmailAddress", EmailAddress); Parameters.Add("@Password", Password);
            Parameters.Add("@Privilege", Privilege); Parameters.Add("@FName", FName); Parameters.Add("@MInit", MInit);
            Parameters.Add("@LName", LName); Parameters.Add("@Gender", Gender); Parameters.Add("@BirthDate", BirthDate);
            Parameters.Add("@Phone", Phone);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public DataTable agentPhone(int AreaID)
        {
            string storedProcedureName = StoredProcedures.AgentPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AreaID", AreaID);
            return dbMan.ExecuteReader(storedProcedureName, Parameters);
        }

        

        //close connection 
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}