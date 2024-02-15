public abstract class Item
{
    protected string _shapeName;
    protected float _volume;
    protected float _base;

    private bool _simpleColor;
    private bool _doubleColor;
    private bool _tripleColor;
    private bool _insect;
    private bool _fish;
    private bool _rock;
    private bool _skull;
    private bool _flower;
    private bool _liquidCore;
    private bool _fineGlitter;
    private bool _largeGlitter;
    private bool _foilStrips;
    private bool _glowPigment;
    private bool _woodBase;
    private bool _metalBase;
    private bool _woodText;
    private bool _metalText;
    private int _letters;



    public Item()
    {
        _simpleColor = false;
        _doubleColor = false;
        _tripleColor = false;
        _insect = false;
        _fish = false;
        _rock = false;
        _skull = false;
        _flower = false;
        _liquidCore = false;
        _fineGlitter = false;
        _largeGlitter = false;
        _foilStrips = false;
        _glowPigment = false;
        _woodBase = false;
        _metalBase = false;
        _woodText = false;
        _metalText = false;
        _letters = 0;
    }



    public abstract float CalculateVolume();

    public abstract float CalculateBase();
}