using System.Collections.Generic;
using AdminData.Models;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace AdminData.DataAccess
{
  public interface ISuppliersRepository
  {
    IEnumerable<SpreadsheetDetail> GetSpreadsheetDetail(string supplier, string status);
  }
}