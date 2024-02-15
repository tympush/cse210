public class Prices
{
    private float _resinPricePerCM3;

    private float _simpleColorPrice;
    private float _doubleColorPrice;
    private float _tripleColorPrice;

    private float _insectPrice;
    private float _fishPrice;
    private float _rockPrice;
    private float _skullPrice;
    private float _flowerPrice;
    private float _liquidCorePrice;

    private float _fineGlitterPrice;
    private float _largeGlitterPrice;
    private float _foilStripsPrice;
    private float _glowPigmentPrice;

    private float _woodBasePricePerCM2;
    private float _metalBasePricePerCM2;

    private float _woodTextPricePerLetter;
    private float _metalTextPricePerLetter;



    public Prices()
    {
        _resinPricePerCM3 = 0.08f;

        _simpleColorPrice = 1f;
        _doubleColorPrice = 2.25f;
        _tripleColorPrice = 3.5f;

        _insectPrice = 4.5f;
        _fishPrice = 3.75f;
        _rockPrice = 2f;
        _skullPrice = 2.5f;
        _flowerPrice = 1.75f;
        _liquidCorePrice = 5f;

        _fineGlitterPrice = 0.75f;
        _largeGlitterPrice = 1.25f;
        _foilStripsPrice = 1.5f;
        _glowPigmentPrice = 2f;

        _woodBasePricePerCM2 = 0.07f;
        _metalBasePricePerCM2 = 0.2f;

        _woodTextPricePerLetter = 0.15f;
        _metalTextPricePerLetter = 0.5f;
    }
}