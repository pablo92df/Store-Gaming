﻿using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Interfaces
{
	public interface IProveedor_Services
	{
		Task<List<ProveedorDomain>> GetProveedores();
	}
}
