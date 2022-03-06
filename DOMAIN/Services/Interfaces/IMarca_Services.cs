using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Interfaces
{
	public interface IMarca_Services
	{
		Task<MarcaDomain> AddSingleMarca(string name);
		Task<List<MarcaDomain>> GetMarca();
	//	Task<> UpdateApplicant(Int64 applicant_id, string name, string surname, DateTime birthday, string email, string phone_number);


	}
}
