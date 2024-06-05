using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implement;

public class PayDetailRepo: IPayDetailRepo
{
    MagiCarContext context;
    public PayDetailRepo(MagiCarContext context)
    {
        this.context = context;
    }

    public PayDetail Add(PayDetail p)
    {
        try
        {
            context.PayDetails.Add(p);
            context.SaveChanges();
            return p;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to add a new payDetail🙁");
        }
    }

    public PayDetail Delete(int id)
    {
        try
        {
            PayDetail remove = context.PayDetails.FirstOrDefault(payDetail => payDetail.Id == id);
            context.PayDetails.Remove(remove);
            context.SaveChanges();
            return remove;

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Failed to delete payDetail {id}🙁.");
        }
    }

    public List<PayDetail> GetAll()
    {
        try
        {
            return context.PayDetails.ToList();

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to get all the payDetail🙁.");
        }
    }

    public PayDetail GetById(int id)
    {
        try
        {
            return context.PayDetails.FirstOrDefault(payDetail => payDetail.Id == id);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception($"Error in getting a single payDetail {id} data.");
        }
    }

    public PayDetail Update(PayDetail p)
    {
        try
        {
            PayDetail payDetail = context.PayDetails.FirstOrDefault(payDetail => payDetail.Id == p.Id);
            if (payDetail != null)
            {
                payDetail.Number = p.Number;
                payDetail.Validity = p.Validity;
                payDetail.Cvv = p.Cvv;         
            }
            context.SaveChanges();
            return p;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Failed to update the payDetail🙁.");
        }
    }
}
