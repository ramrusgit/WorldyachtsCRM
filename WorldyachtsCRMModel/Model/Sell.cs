﻿namespace WorldyachtsCRMModel.Model
{
    public class Sell
    {
        /// <summary>
        /// This class works with Sell model.
        /// </summary>
        public int SellId { get; set; }
        public int CheckId { get; set; }
        public int ProductId { get; set; }

        public virtual Check Check { get; set; }
        public virtual Product Product { get; set; }
    }
}
