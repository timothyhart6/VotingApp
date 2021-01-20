using System.Threading.Tasks;

namespace CivicsApp.Models.Bills.ServiceLayer
{
    public interface IBillService
    {
        Task<BillDetails> FetchBillDetailsAsync(string billSlug);
    }
}