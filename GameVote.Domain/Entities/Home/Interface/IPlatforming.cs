using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities.Home.Interface
{
    public interface IPlatforming
    {
        string PlatformGame { get; set; }
        float PriceRelise { get; set; }
        float PriceNow { get; set; }
        DateTime DataRelise { get; set; }
        DateTime DataLostSale { get; set; }
    }
}
