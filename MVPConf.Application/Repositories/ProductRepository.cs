using MVPConf.Application.Models;
using MVPConf.Application.Repositories.Interfaces;
using System.Collections.Generic;

namespace MVPConf.Application.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            var list = new List<Product>();
            list.Add(new Product(1, "Mobile phone", "A mobile phone, cellular phone, cell phone, cellphone, handphone, or hand phone, sometimes shortened to simply mobile, cell or just phone, is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area", 500));
            list.Add(new Product(2, "TV 70'", "Television, sometimes shortened to TV or telly, is a telecommunication medium used for transmitting moving images in monochrome (black and white), or in color, and in two or three dimensions and sound.", (decimal)1200.49));
            list.Add(new Product(3, "Soundbar", "A soundbar, sound bar or media bar is a type of loudspeaker that projects audio from a wide enclosure. It is much wider than it is tall, partly for acoustic reasons, and partly so it can be mounted above or below a display device.", (decimal)399.99));
            list.Add(new Product(4, "Refrigerator", "A refrigerator is one of our most valuable household appliances. It keeps food and drinks cool, by pushing a liquid refrigerant through a sealed system, which causes it to vaporize, and draw heat out of the fridge.", (decimal)1799.99));

            return list;
        }
    }
}
