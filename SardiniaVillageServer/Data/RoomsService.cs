using SardiniaVillageServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SardiniaVillageServer.Data
{
    public class RoomsService
    {
        List<Rooms> RoomList = new List<Rooms>();
        public List<Rooms> GetRooms()
        {
			RoomList.Add(new Rooms(1150, "Fronte Mare A1", "Mezza pensione con stanza vista mare.", 110, true, 1, "images/1150.jpg",
			new List<Price>
			{
						new Price(1,"Alta Stagione",110),
						new Price(2,"Media Stagione",80),
						new Price(3,"Bassa Stagione",50)
			}));

			RoomList.Add(new Rooms(1151, "Fronte Mare A4", "Mezza pensione con stanza vista mare.", 320, true, 4, "images/1151.jpg",
			new List<Price>
			{
				new Price(1,"Alta Stagione",320),
				new Price(2,"Media Stagione",160),
				new Price(3,"Bassa Stagione",90)
			}));

			RoomList.Add(new Rooms(1152, "Fronte Mare A2", "Mezza pensione con stanza vista mare.", 240, true, 4, "images/1152.jpg",
			new List<Price>
			{
				new Price(1,"Alta Stagione",240),
				new Price(2,"Media Stagione",110),
				new Price(3,"Bassa Stagione",70)
			}));

			return RoomList;
		}
    }
}
