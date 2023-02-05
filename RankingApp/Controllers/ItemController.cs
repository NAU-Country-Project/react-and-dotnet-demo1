using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;

namespace RankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{ID =1, Title = "The Godfather", ImageID=1, Rank=0,ItemType=1 },
            new ItemModel{ID =2, Title = "Highlander", ImageID=2, Rank=0,ItemType=1 },
            new ItemModel{ID =3, Title = "Highlander II", ImageID=3, Rank=0,ItemType=1 },
            new ItemModel{ID =4, Title = "The Last of the Mohicans", ImageID=4, Rank=0,ItemType=1 },
            new ItemModel{ID =5, Title = "Police Academy 6", ImageID=5, Rank=0,ItemType=1 },
            new ItemModel{ID =6, Title = "Rear Window", ImageID=6, Rank=0,ItemType=1 },
            new ItemModel{ID =7, Title = "Road House", ImageID=7, Rank=0,ItemType=1 },
            new ItemModel{ID =8, Title = "The Shawshank Redemption", ImageID=8, Rank=0,ItemType=1 },
            new ItemModel{ID =9, Title = "Star Treck IV", ImageID=9, Rank=0,ItemType=1 },
            new ItemModel{ID =10, Title = "Superman 4", ImageID=10, Rank=0,ItemType=1 },
            new ItemModel{ID = 11, Title = "Abbey Road", ImageID=11, Rank=0,ItemType=2 },
            new ItemModel{ID = 12, Title = "Adrenalize", ImageID=12, Rank=0,ItemType=2 },
            new ItemModel{ID = 13, Title = "Back in Black", ImageID=13, Rank=0,ItemType=2 },
            new ItemModel{ID = 14, Title = "Enjoy the Silence", ImageID=14, Rank=0,ItemType=2 },
            new ItemModel{ID = 15, Title = "Parachutes", ImageID=15, Rank=0,ItemType=2 },
            new ItemModel{ID = 16, Title = "Ride the Lightning", ImageID=16, Rank=0,ItemType=2 },
            new ItemModel{ID = 17, Title = "Rock or Bust", ImageID=17, Rank=0,ItemType=2 },
            new ItemModel{ID = 18, Title = "Rust in Peace", ImageID=18, Rank=0,ItemType=2 },
            new ItemModel{ID = 19, Title = "St. Anger", ImageID=19, Rank=0,ItemType=2 },
            new ItemModel{ID = 20, Title = "The Final Countdown", ImageID=20, Rank=0,ItemType=2 }
        };

        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}
