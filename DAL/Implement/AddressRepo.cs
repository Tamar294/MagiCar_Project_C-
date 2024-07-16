using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class AddressRepo : IAddressRepo
{
    MagiCarContext context;
    public AddressRepo(MagiCarContext context)
    {
        this.context = context;
    }

    public Address Add(Address a)
    {
        try
        {
            context.Addresses.Add(a);
            context.SaveChanges();
            return a;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new address🙁");
        }
    }

    public Address Delete(int id)
    {
        try
        {
            Address remove = context.Addresses.FirstOrDefault(address => address.Id == id);
            context.Addresses.Remove(remove);
            context.SaveChanges();
            return remove;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete address {id}🙁.");
        }
    }

    public List<Address> GetAll()
    {
        try
        {
            return context.Addresses.ToList();

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the addresses🙁.");
        }
    }

    public Address GetById(int id)
    {
        try
        {
            return context.Addresses.FirstOrDefault(address => address.Id == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single address {id} data.");
        }
    }


    public Address Update(Address a, int id) { 
        try
        {
            Address address = context.Addresses.FirstOrDefault(address => address.Id == a.Id);
            if (address != null)
            {
                a.City = address.City;
                a.Neighborhood = address.Neighborhood;
                a.Street = address.Street;
                a.BuildingNumber = address.BuildingNumber;
            }
            context.SaveChanges();
            return a;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the address🙁.");
        }
    }
}
