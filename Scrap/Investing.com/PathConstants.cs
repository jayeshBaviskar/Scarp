using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap.Investing.com
{
    class PathConstants
    {

        String shareName = "/html/body/div/div[4]/section[2]/div/header/div/div[1]/section/h1/span";
        String price = "/html/body/div/div[4]/section[2]/div/header/div/div[2]/div[1]/div[1]/bdo";
        String difference = "/html/body/div/div[4]/section[2]/div/header/div/div[2]/div[1]/div[1]/span[1]";
        String difference_Percentage = "/html/body/div/div[4]/section[2]/div/header/div/div[2]/div[1]/div[1]/span[2]/bdo/span";
    }
}
