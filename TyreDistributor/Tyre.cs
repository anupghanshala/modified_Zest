namespace TyreDistributor
{
    public abstract class Tyre
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
    }

    public class AlfaRomeo :Tyre
    {

    }

    public class BmwMini : Tyre
    {

    }

    public class BmwEstate : Tyre
    {

    }


    /// <summary>
    ///  We can Further Break out our code based on the model below 
    /// </summary>
    public abstract class TyreModel
    {
        public string modelName { get; set; }

    }
    public class ModelSuv : TyreModel
    {

    }
    public class ModelMini : TyreModel
    {

    }
    public class ModelEstate : TyreModel
    {

    }

}
