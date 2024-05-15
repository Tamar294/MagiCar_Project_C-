using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class CreditDetailRepo: ICreditDetailRepo
{
    MagiCarContext context;
    public CreditDetailRepo(MagiCarContext context)
    {
        this.context = context;
    }

    public CreditDetail Add(CreditDetail c)
    {
        try
        {
            context.CreditDetails.Add(c);
            context.SaveChanges();
            return c;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new creditDetail🙁");
        }
    }

    public CreditDetail Delete(int id)
    {
        try
        {
            CreditDetail remove = context.CreditDetails.FirstOrDefault(creditDetail => creditDetail.Id == id);
            context.CreditDetails.Remove(remove);
            context.SaveChanges();
            return remove;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete creditDetail {id}🙁.");
        }
    }

    public List<CreditDetail> GetAll()
    {
        try
        {
            return context.CreditDetails.ToList();

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the creditDetail🙁.");
        }
    }

    public CreditDetail GetById(int id)
    {
        try
        {
            return context.CreditDetails.FirstOrDefault(creditDetail => creditDetail.Id == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single creditDetail {id} data.");
        }
    }

    public CreditDetail Update(int id, CreditDetail c)
    {
        try
        {
            CreditDetail creditDetail = context.CreditDetails.FirstOrDefault(creditDetail => creditDetail.Id == id);
            if (creditDetail != null)
            {
                creditDetail.Number = c.Number;
                creditDetail.Validity = c.Validity;
                creditDetail.Cvv = c.Cvv;         
            }
            context.SaveChanges();
            return c;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the creditDetail🙁.");
        }
    }
}
