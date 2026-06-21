using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Server=LocalHost;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        using SqlConnection connection =
            new(connectionString);

        connection.Open();

        // INSERT
        SqlCommand insertCmd = new(
            "INSERT INTO Employees(Name,Salary) VALUES('Reddy',50000)",
            connection);

        insertCmd.ExecuteNonQuery();

        // READ
        SqlCommand readCmd = new(
            "SELECT * FROM Employees",
            connection);

        using SqlDataReader reader =
            readCmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(
                $"{reader["Id"]} {reader["Name"]} {reader["Salary"]}");
        }

        reader.Close();

        // UPDATE
        SqlCommand updateCmd = new(
            "UPDATE Employees SET Salary=60000 WHERE Name='Reddy'",
            connection);

        updateCmd.ExecuteNonQuery();

        // DELETE
        SqlCommand deleteCmd = new(
            "DELETE FROM Employees WHERE Name='Reddy'",
            connection);

        deleteCmd.ExecuteNonQuery();

        Console.WriteLine("CRUD Operations Completed");
    }
}