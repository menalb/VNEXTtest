using System.Collections.Generic;
using MongoDB.Driver;

public interface ICustomerRepository{
	IEnumerable<Customer> GetCutomers();	
}

public class CustomerRepository : ICustomerRepository
{
	private string _connectionString="mongodb://localhost";
	
	public IEnumerable<Customer> GetCutomers(){
		var client= new MongoClient(_connectionString);
		var server= client.GetServer();
		var db=server.GetDatabase("test");
		var customers=db.GetCollection<Customer>("customers");
		return customers.FindAll();
		/*
		return new List<Customer>{
			new Customer{ Name ="Giorgio", Surname ="Bianchi" },
			new Customer{ Name ="Mario", Surname ="Rossi" }
			
		};
		*/
	}
}