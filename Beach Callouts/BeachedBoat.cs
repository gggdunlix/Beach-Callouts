using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CitizenFX.Core;
using FivePD.API;
using FivePD.API.Utils;
using CitizenFX.Core.Native;
using System.Linq;

[CalloutProperties("Beached Boat", "GGGDunlix", "1.0.0")]
public class BeachedBoat : FivePD.API.Callout
{
    private Ped driver;
    private Vehicle boat;
    private Vector3[] coordinates =
    {
        new Vector3(-1713.609f, -1059.618f, 1.552729f),
        new Vector3(-1761.137f, -1020.727f, 1.557871f),
        new Vector3(-1808.809f, -955.4135f, 1.909222f),
        new Vector3(-1890.712f, -814.2408f, 2.613446f),
        new Vector3(-2009.805f, -657.7264f, 2.629424f),
        new Vector3(-2099.629f, -561.2128f, 2.611236f),
        new Vector3(-2121.679f, -510.2366f, 1.938225f),
        new Vector3(-2163.901f, -468.4352f, 1.9385f),
        new Vector3(-2232.551f, -428.5363f, 2.199604f),
        new Vector3(-2288.476f, -387.7354f, 2.409646f),
        new Vector3(-2360.969f, -342.3628f, 3.36557f),
        new Vector3(-2490.464f, -280.5616f, 3.544551f),
        new Vector3(-2616.686f, -208.1988f, 2.71534f),
        new Vector3(-2717.59f, -121.2617f, 1.769751f),
        new Vector3(-2821.677f, -63.00797f, 1.248621f),
        new Vector3(-2936.575f, -33.01345f, 2.096472f),
        new Vector3(-3033.484f, 0.9195622f, 1.4543f),
        new Vector3(-3100.601f, 80.30987f, 2.521947f),
        new Vector3(-3113.819f, 166.3088f, 1.590334f),
        new Vector3(-3145.923f, 234.7877f, 2.616011f),
        new Vector3(-3150.088f, 322.8024f, 2.048182f),
        new Vector3(-3111.876f, 430.9958f, 1.990061f),
        new Vector3(-3091.089f, 566.808f, 1.992687f),
        new Vector3(-3175.615f, 720.7891f, 1.679324f),
        new Vector3(-3251.484f, 882.3868f, 1.28035f),
        new Vector3(-3284.954f, 935.5549f, 1.718765f),
        new Vector3(-3301.332f, 1032.649f, 1.52288f),
        new Vector3(-3271.811f, 1224.618f, 1.771565f),
        new Vector3(-3242.928f, 1317.199f, 2.080496f),
        new Vector3(-3224.564f, 1365.524f, 0.7421051f),
        new Vector3(-3203.566f, 1402.466f, 1.47703f),
        new Vector3(-3165.13f, 1437.173f, 1.900924f),
        new Vector3(-3109.501f, 1486.234f, 0.9676753f),
        new Vector3(-3015.151f, 1592.211f, 2.386315f),
        new Vector3(-3105.698f, 1637.275f, 1.282404f),
        new Vector3(-3166.986f, 1737.359f, 3.341332f),
        new Vector3(-3058.764f, 1891.719f, 0.8832939f),
        new Vector3(-3089.043f, 2010.127f, 1.216734f),
        new Vector3(-3043.531f, 2194.887f, 2.661696f),
        new Vector3(-2981.361f, 2233.641f, 3.508288f),
        new Vector3(-2915.874f, 2268.448f, 1.699604f),
        new Vector3(-2842.416f, 2298.085f, 2.276269f),
        new Vector3(-2825.254f, 2325.133f, 2.286398f),
        new Vector3(-2793.915f, 2358.455f, 2.197201f),
        new Vector3(-2793.598f, 2388.526f, 1.370193f),
        new Vector3(-2786.426f, 2487.118f, 2.285214f),
        new Vector3(-2757.034f, 2552.464f, 1.029322f),
        new Vector3(-2752.925f, 2872.191f, 1.207724f),
        new Vector3(-2910.985f, 3066.961f, 3.010694f),
        new Vector3(-2985.817f, 3208.86f, 1.499641f),
        new Vector3(-3150.873f, 3257.807f, 1.417439f),
        new Vector3(-3093.76f, 3429.451f, 1.487988f),
        new Vector3(-3004.997f, 3545.743f, 1.346907f),
        new Vector3(-2863.592f, 3580.076f, 0.9956032f),
        new Vector3(-2786.575f, 3576.901f, 1.07196f),
        new Vector3(-2699.312f, 3571.923f, 1.467123f),
        new Vector3(-2642.389f, 3582.86f, 1.350967f),
        new Vector3(-2566.863f, 3751.324f, 1.775595f),
        new Vector3(-2526.559f, 3966.544f, 1.161404f),
        new Vector3(-2517.306f, 4148.725f, 1.111308f),
        new Vector3(-2431.558f, 4308.161f, 2.142445f),
        new Vector3(-2328.523f, 4434.104f, 0.9294986f),
        new Vector3(-2259.12f, 4511.77f, 0.9441963f),
        new Vector3(-2205.279f, 4617.897f, 0.7960677f),
        new Vector3(-2146.013f, 4612.479f, 1.075801f),
        new Vector3(-2014.57f, 4591.314f, 0.9798094f),
        new Vector3(-1902.371f, 4583.73f, 1.12187f),
        new Vector3(-1867.49f, 4801.945f, 2.153732f),
        new Vector3(-1867.49f, 4801.942f, 2.150677f),
        new Vector3(-1777.103f, 4886.96f, 1.599478f),
        new Vector3(-1746.847f, 4969.75f, 1.719205f),
        new Vector3(-1430.939f, 5202.267f, 2.16474f),
        new Vector3(-1396.978f, 5245.332f, 1.993945f),
        new Vector3(-1386.464f, 5320.832f, 1.420065f),
        new Vector3(-1370.548f, 5381.737f, 0.6228627f),
        new Vector3(-1329.928f, 5373.94f, 1.612577f),
        new Vector3(-1200.953f, 5389.643f, 2.105985f),
        new Vector3(-983.9252f, 5563.053f, 1.895996f),
        new Vector3(-902.2883f, 5653.395f, 1.121145f),
        new Vector3(-908.1329f, 5731.36f, 2.67761f),
        new Vector3(-903.6883f, 5771.286f, 2.186847f),
        new Vector3(-871.4551f, 5912.141f, 1.452848f),
        new Vector3(-925.6619f, 6005.733f, 1.517522f),
        new Vector3(-941.9733f, 6056.309f, 1.625115f),
        new Vector3(-965.8051f, 6160.683f, 1.884983f),
        new Vector3(-999.0026f, 6270.299f, 1.520947f),
        new Vector3(-890.2141f, 6156.842f, 2.336667f),
        new Vector3(-854.8394f, 6067.872f, 1.761809f),
        new Vector3(-807.2587f, 6014.871f, 1.539236f),
        new Vector3(-738.9218f, 6060.118f, 0.923476f),
        new Vector3(-649.4171f, 6265.779f, 2.625786f),
        new Vector3(-547.4432f, 6418.892f, 2.289458f),
        new Vector3(-397.8232f, 6494.097f, 2.792053f),
        new Vector3(-283.6362f, 6597.473f, 1.442334f),
        new Vector3(-235.675f, 6655.029f, 1.236654f),
        new Vector3(-163.1588f, 6705.388f, 1.222539f),
        new Vector3(-99.97874f, 6771.086f, 1.053839f),
        new Vector3(-35.85989f, 6910.48f, 0.8641742f),
        new Vector3(19.23206f, 7053.286f, 0.89959f),
        new Vector3(34.15948f, 7180.389f, 1.406743f),
        new Vector3(80.53728f, 7230.922f, 2.18467f),
        new Vector3(130.8992f, 7069.623f, 1.325881f),
        new Vector3(239.6344f, 7054.901f, 1.777092f),
        new Vector3(342.0851f, 6959.206f, 1.481919f),
        new Vector3(430.8513f, 6823.705f, 1.836293f),
        new Vector3(479.1561f, 6764.693f, 0.4400496f),
        new Vector3(689.8915f, 6676.896f, 1.471979f),
        new Vector3(713.1302f, 6661.407f, 1.9278f),
        new Vector3(804.2488f, 6667.235f, 1.587283f),
        new Vector3(898.167f, 6647.849f, 1.026828f),
        new Vector3(978.0195f, 6617.825f, 1.930534f),
        new Vector3(1094.189f, 6624.811f, 1.554758f),
        new Vector3(1131.604f, 6601.118f, 1.547561f),
        new Vector3(1186.994f, 6597.547f, 1.41269f),
        new Vector3(1319.702f, 6623.529f, 1.710532f),
        new Vector3(1568.551f, 6664.975f, 1.783395f),
        new Vector3(2341.733f, 6668.729f, 1.519017f),
        new Vector3(2384.089f, 6646.03f, 1.378711f),
        new Vector3(2460.498f, 6615.896f, 2.012224f),
        new Vector3(2511.794f, 6608.17f, 1.585517f),
        new Vector3(2567.85f, 6616.94f, 1.67928f),
        new Vector3(2841.163f, 6443.782f, 1.521489f),
        new Vector3(3360.116f, 5692.028f, 2.947103f),
        new Vector3(3222.429f, 5333.229f, 2.065178f),
        new Vector3(3824.031f, 4518.726f, 1.954423f),
        new Vector3(3859.549f, 4407.356f, 2.806325f),
        new Vector3(3876.582f, 4309.121f, 2.232673f),
        new Vector3(3935.655f, 4016.36f, 2.338382f),
        new Vector3(3881.285f, 3959.089f, 1.946589f),
        new Vector3(3754.022f, 3821.234f, 1.739975f),
        new Vector3(3848.344f, 3638.333f, 4.137351f),
        new Vector3(3955.338f, 3729.561f, 1.183416f),
        new Vector3(3931.453f, 3726.028f, 1.089999f),
        new Vector3(3980.86f, 3627.387f, 0.8830282f),
        new Vector3(3914.243f, 3445.16f, 3.659275f),
        new Vector3(3903.527f, 3357.933f, 1.856263f),
        new Vector3(3865.496f, 3265.784f, 2.206096f),
        new Vector3(3780.108f, 3175.458f, 1.912283f),
        new Vector3(3756.807f, 3114.173f, 1.517082f),
        new Vector3(3286.103f, 2293.311f, 1.259709f),
        new Vector3(3275.677f, 2199.063f, 2.308719f),
        new Vector3(3254.687f, 2159.363f, 1.93262f),
        new Vector3(3023.053f, 2072.031f, 2.974715f),
        new Vector3(2773.249f, 1245.864f, 2.989626f),
        new Vector3(2959.001f, 608.2818f, 1.156665f),
        new Vector3(2966.374f, 600.5004f, 2.069313f),
        new Vector3(2896.881f, 250.0867f, 2.342266f),
        new Vector3(2830.745f, -648.4056f, 1.31174f),
        new Vector3(2665.627f, -1012.504f, 1.475244f),
        new Vector3(2495.316f, -1322.904f, 0.7859902f),
        new Vector3(2308.568f, -2137.47f, 1.005058f),
        new Vector3(1777.729f, -2709.936f, 1.516126f),
        new Vector3(1614.912f, -2724.811f, 0.9434402f),
        new Vector3(1381.061f, -2748.3f, 1.79737f),
        new Vector3(1215.483f, -2700.361f, 0.7656689f),
        new Vector3(1074.25f, -2674.529f, 2.703398f),
        new Vector3(-1773.308f, -2619.987f, 2.244334f),
        new Vector3(-1677.547f, -2447.56f, 2.284784f),
        new Vector3(-1610.627f, -2335.597f, 2.169451f),
        new Vector3(-1444.966f, -2167.503f, 2.539988f),
        new Vector3(-1381.578f, -2115.351f, 3.257396f),
        new Vector3(-1287.433f, -2041.71f, 2.008071f),
        new Vector3(-1212.275f, -1962.317f, 3.41699f),
        new Vector3(-1171.438f, -1923.346f, 2.434052f),
        new Vector3(-1127.227f, -1876.017f, 2.691216f),
        new Vector3(-1039.431f, -1836.559f, 1.223504f),
        new Vector3(-904.04f, -1718.418f, 1.409849f),
        new Vector3(-1264.026f, -1824.021f, 1.357604f),
        new Vector3(-1319.535f, -1746.872f, 1.014213f),
        new Vector3(-1385.805f, -1647.038f, 1.15505f),
        new Vector3(-1439.042f, -1551.528f, 0.8493775f),
        new Vector3(-1494.859f, -1433.686f, 0.8278168f),
        new Vector3(-1520.757f, -1351.557f, 1.0355f),
        new Vector3(-1550.207f, -1258.122f, 1.063483f),
        new Vector3(-1588.119f, -1204.72f, 1.011371f),
        new Vector3(-1619.959f, -1141.094f, 1.118194f),
        new Vector3(-1716.554f, -1062.364f, 1.183604f),
        new Vector3(-1716.16f, -1059.414f, 1.40085f)
    };

    public BeachedBoat()
    {

        Vector3 location = coordinates.OrderBy(x => World.GetDistance(x, Game.PlayerPed.Position)).Skip(1).First();

        InitInfo(location);
        ShortName = "Beached Boat";
        CalloutDescription = "A Boat is beached on the shore! Respond in Code 2.";
        ResponseCode = 2;
        StartDistance = 130f;
    }

    public override async Task OnAccept()
    {
        InitBlip(25);

        

    }

    public async override void OnStart(Ped player)
    {
        base.OnStart(player);

        var boats = new[]
          {
               VehicleHash.Dinghy,
               VehicleHash.Dinghy2,
               VehicleHash.Dinghy3,
               VehicleHash.Dinghy4,
               VehicleHash.Jetmax,
               VehicleHash.Marquis,
               VehicleHash.Speeder,
               VehicleHash.Speeder2,
               VehicleHash.Squalo,
               VehicleHash.Suntrap,
               VehicleHash.Toro,
               VehicleHash.Tropic,
               VehicleHash.Tropic2,
               VehicleHash.Toro2,
               VehicleHash.Tug


           };

        boat = await SpawnVehicle(boats[RandomUtils.Random.Next(boats.Length)], Location, 180);



        Random random = new Random();
        int ifdriver = random.Next(0, 1);

        if (ifdriver == 1)
        {
            driver = await SpawnPed(RandomUtils.GetRandomPed(), new Vector3(Location.X, Location.Y, Location.Z + 5f));
            driver.AttachBlip();
            int ifdead = random.Next(0, 1);
            if (ifdead == 1)
            {
                driver.Kill();
            }
        }
        boat.AttachBlip();

    }
}