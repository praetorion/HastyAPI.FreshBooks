﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace HastyAPI.FreshBooks.Tests {
	public class ClientTests {

		public class Dynamic {
			public void ListAll() {
				var res = Shared.NewCaller().Call("client.list");
				Console.Write(res.ToString());
			}

			public void Clients_Get() {
				var res = Shared.NewCaller().Call("client.get", x => x.client_id = 12);
				Console.Write(res.ToString());

				Console.Write(res.response);
			}
		}
	}
}
