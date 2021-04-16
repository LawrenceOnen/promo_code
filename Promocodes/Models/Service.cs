namespace Promocodes.Models
{
    public class Service
    {

        //Services data
        public int id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }
        public int Activated { get; set; }

        /*
        *  CreatePromoCode: method is used to create the promotion promo
        */
        public string createPromoCode (){
            //TODO:Write logic here.
            return Code;
        }

        /*
        * activateBonus: method sets bonus on 
        */
        public void activateBonus()
        {
            //TODO: add logic here
        }

    }
}