// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3x4
    {
        [TestCompiler]
        public static void float3x4_zero()
        {
            TestUtils.AreEqual(float3x4.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c0.z, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c1.z, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c2.x, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c2.y, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c2.z, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c3.x, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c3.y, 0.0f);
            TestUtils.AreEqual(float3x4.zero.c3.z, 0.0f);
        }

        [TestCompiler]
        public static void float3x4_operator_equal_wide_wide()
        {
            float3x4 a0 = float3x4(-135.18924f, -49.0941162f, 169.129822f, 240.8053f, 314.7392f, 442.393f, 177.924438f, 335.5334f, 168.15448f, 350.729553f, 367.178467f, 46.9414673f);
            float3x4 b0 = float3x4(-220.014648f, 66.98004f, 499.2016f, -371.1131f, 208.448669f, 390.8037f, -72.44382f, 362.97644f, 194.678345f, 471.644836f, -404.044678f, -144.696747f);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x4 a1 = float3x4(188.76416f, -97.2113953f, -293.320984f, -234.822937f, 417.0337f, 26.3864136f, 269.245728f, 29.4741821f, 479.485229f, -237.230957f, -221.9837f, -506.672546f);
            float3x4 b1 = float3x4(-494.446655f, -252.970367f, 234.417114f, 398.724f, 260.4287f, 370.144226f, 89.579834f, -434.816833f, -109.845337f, 336.973022f, -409.154968f, 500.387573f);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x4 a2 = float3x4(-22.98944f, 487.260864f, -419.731964f, 337.2033f, 245.043884f, 390.215881f, 84.4129639f, 434.2079f, -68.7284241f, 485.769958f, 413.169739f, -418.2693f);
            float3x4 b2 = float3x4(-174.081818f, 395.101135f, 350.3393f, -243.144592f, -416.397369f, 151.576477f, -18.2243347f, -431.677917f, -468.330963f, 429.495728f, 477.389221f, -433.4254f);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x4 a3 = float3x4(-346.795868f, 504.159668f, 345.186279f, -434.713043f, -499.7741f, 282.019043f, 259.15625f, 306.455933f, 435.2254f, -386.8997f, 211.364014f, -7.229828f);
            float3x4 b3 = float3x4(273.5464f, -34.9762268f, 221.968445f, 85.91913f, -85.59894f, 392.7608f, -117.924072f, -445.3056f, -242.468964f, 173.643066f, 389.897766f, -14.2904663f);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_equal_wide_scalar()
        {
            float3x4 a0 = float3x4(65.6712f, 404.415527f, -269.730164f, 83.6306152f, 152.9945f, -155.868286f, 314.671265f, 386.365173f, 290.04895f, -132.6352f, -65.66748f, -69.68326f);
            float b0 = (-155.815765f);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x4 a1 = float3x4(-191.190765f, -232.895691f, -319.144043f, -49.70108f, -300.8819f, 333.396851f, 386.3775f, -296.7019f, -309.1172f, 141.542358f, -227.323334f, 83.87286f);
            float b1 = (186.845215f);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x4 a2 = float3x4(-410.91687f, -390.103577f, 36.57434f, -427.541443f, -268.170837f, 175.8117f, -193.47995f, 291.051941f, 423.97168f, -429.8739f, -275.156952f, -56.3323669f);
            float b2 = (110.501282f);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x4 a3 = float3x4(-95.83597f, 253.006165f, -300.509521f, 314.866516f, 195.616211f, -26.1289063f, -284.7747f, -242.672058f, 140.3606f, 505.644348f, 506.537964f, -502.3698f);
            float b3 = (-124.865326f);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float3x4 b0 = float3x4(-400.4892f, -71.2868347f, 156.978088f, -225.238739f, 499.141785f, -211.979919f, 428.311951f, -489.501343f, -5.691559f, -30.8659363f, -362.9831f, 184.503174f);
            bool3x4 r0 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-160.470612f);
            float3x4 b1 = float3x4(316.668823f, 390.369263f, 505.1051f, -294.6487f, 443.1991f, 96.5592651f, -257.012939f, -245.054962f, 326.464844f, -23.9599f, -168.694885f, 386.2486f);
            bool3x4 r1 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-227.090637f);
            float3x4 b2 = float3x4(-336.612427f, 365.108154f, -405.390839f, -473.995483f, 298.435364f, -149.86322f, 450.0664f, 153.47644f, 56.28778f, 39.3421021f, -350.403717f, -482.717224f);
            bool3x4 r2 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (239.9654f);
            float3x4 b3 = float3x4(-3.40603638f, -1.49484253f, 105.960449f, 151.537537f, 63.2832031f, -289.693176f, 137.553772f, -247.666473f, -339.420563f, 23.2382813f, 21.1778564f, 477.03656f);
            bool3x4 r3 = bool3x4(false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_not_equal_wide_wide()
        {
            float3x4 a0 = float3x4(279.994141f, -43.34201f, -465.724731f, 317.466553f, 85.7149658f, 360.8905f, 366.081543f, 154.542847f, 332.4262f, 397.11322f, -431.374969f, 489.0108f);
            float3x4 b0 = float3x4(-460.9121f, -476.009033f, 468.1364f, -341.012543f, -62.65805f, -458.801666f, -457.730225f, -59.5232544f, 3.024231f, 155.812744f, -19.8399048f, -6.01693726f);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x4 a1 = float3x4(398.4336f, -489.817932f, 171.4049f, -67.82968f, -192.278717f, 227.84082f, 62.1381836f, 262.186462f, -404.0531f, 34.449585f, -204.795776f, -285.4118f);
            float3x4 b1 = float3x4(-406.207916f, -102.420715f, -40.362915f, 452.6754f, 93.25757f, -258.378052f, -184.0498f, -379.2353f, -370.687317f, -255.947235f, 29.0557861f, 322.407654f);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x4 a2 = float3x4(-72.20682f, 444.749268f, 238.81781f, 365.1801f, -437.9229f, -362.442627f, 445.954346f, -0.417480469f, -506.828369f, 245.477051f, -173.571045f, 390.338562f);
            float3x4 b2 = float3x4(415.071716f, -467.726135f, -433.784668f, -212.165924f, 474.674927f, 452.483215f, -92.11273f, -385.9221f, 420.2151f, -239.176056f, -99.0791f, 4.476013f);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x4 a3 = float3x4(252.837769f, 47.8658447f, 457.7105f, -313.22113f, 391.203857f, 481.786133f, 26.8878174f, -298.1424f, 240.077454f, -332.455139f, -333.607178f, -313.1897f);
            float3x4 b3 = float3x4(264.348572f, 451.312317f, 232.958008f, -142.6222f, -300.2256f, 268.333252f, -112.103546f, -270.494019f, -71.9932251f, 99.46326f, 321.7033f, 200.059631f);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_not_equal_wide_scalar()
        {
            float3x4 a0 = float3x4(-155.4411f, -19.4266052f, 174.633057f, 507.920715f, 59.177063f, 171.151489f, -58.92328f, -398.176849f, 492.20105f, -165.241516f, 270.341f, -380.243256f);
            float b0 = (-393.413544f);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x4 a1 = float3x4(501.899048f, 458.400452f, 46.7709961f, 161.459961f, 261.514221f, -145.6124f, -0.449920654f, 350.461426f, 202.221008f, 242.664f, 382.677063f, -468.967957f);
            float b1 = (-134.345459f);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x4 a2 = float3x4(-497.459473f, -328.587769f, -506.490326f, 449.348145f, 210.771f, 249.181824f, -338.468536f, 229.670654f, -76.5433044f, 317.286072f, 401.939575f, 210.984863f);
            float b2 = (-80.93225f);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x4 a3 = float3x4(-147.096313f, 207.731384f, 284.3921f, -509.0853f, 414.307617f, -52.2944641f, -140.437927f, -316.787781f, -358.696838f, 312.31897f, 270.629456f, -140.016724f);
            float b3 = (-193.399048f);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float3x4 b0 = float3x4(459.553223f, 436.453247f, -488.714172f, 392.767944f, -266.736633f, 338.557861f, -338.100128f, -152.314545f, -452.820679f, 209.439331f, 50.10797f, 372.4344f);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-488.0213f);
            float3x4 b1 = float3x4(489.740784f, 270.4001f, -472.846771f, -286.850464f, -384.691864f, 443.423523f, 358.7472f, -15.4140625f, -342.179169f, 468.967529f, -130.568085f, 401.785828f);
            bool3x4 r1 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-268.352264f);
            float3x4 b2 = float3x4(-239.231018f, 411.386536f, 139.769348f, 334.522034f, -223.629242f, -12.4884644f, 113.468872f, -189.652252f, -212.846558f, 306.1256f, -178.330383f, 382.141968f);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-340.8656f);
            float3x4 b3 = float3x4(-17.58023f, -409.874847f, -349.70166f, 275.8543f, -229.371948f, -127.505737f, 90.75342f, -422.087128f, -2.44754028f, -280.5517f, -484.374359f, -33.7634277f);
            bool3x4 r3 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_wide_wide()
        {
            float3x4 a0 = float3x4(51.7102661f, -313.85556f, 283.047668f, 235.021912f, 44.07837f, -207.255676f, 3.38293457f, -144.301331f, -69.3696f, -135.667969f, -194.787354f, -33.473877f);
            float3x4 b0 = float3x4(-261.835236f, -19.81073f, -149.25882f, 205.99823f, -306.024384f, 102.121704f, 231.906311f, 179.49884f, 473.2249f, 15.8916626f, 270.049927f, 490.914f);
            bool3x4 r0 = bool3x4(false, true, false, false, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x4 a1 = float3x4(-19.67508f, 423.237976f, -71.6983f, -501.886f, 7.64386f, 302.262878f, -140.5505f, -436.5867f, -351.4417f, 364.970825f, 301.8941f, 407.550964f);
            float3x4 b1 = float3x4(-185.734131f, 76.4331055f, 97.75232f, 419.300781f, 73.953186f, 481.032349f, 7.00744629f, -7.32409668f, -413.075745f, -154.1189f, 449.202881f, 502.014282f);
            bool3x4 r1 = bool3x4(false, false, true, true, true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x4 a2 = float3x4(269.1078f, 462.98822f, 223.884155f, -287.18924f, 283.6386f, 511.864319f, -60.4967957f, -234.303467f, -316.1384f, -417.522156f, 441.643433f, -191.950623f);
            float3x4 b2 = float3x4(-382.315857f, 251.535156f, 143.17395f, 293.660339f, -292.769562f, -43.2182f, -353.4112f, 458.32605f, -114.556458f, 441.429749f, -113.333679f, 435.622925f);
            bool3x4 r2 = bool3x4(false, false, false, true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x4 a3 = float3x4(397.811584f, -144.666626f, 417.079041f, -322.980133f, -81.2850952f, 319.325317f, 146.764038f, -316.583374f, -150.857544f, -314.606323f, 7.14312744f, -458.8273f);
            float3x4 b3 = float3x4(383.656128f, -293.7116f, -391.35498f, 43.12201f, 433.223633f, -201.382446f, -241.421173f, 376.469849f, -503.39743f, -359.780945f, 118.631531f, -510.030518f);
            bool3x4 r3 = bool3x4(false, false, false, true, true, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_wide_scalar()
        {
            float3x4 a0 = float3x4(-221.869781f, -121.546478f, -97.5239258f, 479.8811f, 67.11902f, 137.3288f, 282.9666f, 258.2791f, -111.413147f, -288.081116f, 82.6654053f, -361.6429f);
            float b0 = (199.0675f);
            bool3x4 r0 = bool3x4(true, true, true, false, true, true, false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x4 a1 = float3x4(-68.0881958f, -66.703064f, -78.76297f, 25.7277222f, 101.37085f, -330.442657f, -48.9205322f, 359.604431f, -8.150085f, 241.2768f, -183.437775f, 423.027161f);
            float b1 = (12.7880249f);
            bool3x4 r1 = bool3x4(true, true, true, false, false, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x4 a2 = float3x4(-334.622742f, 300.410156f, 297.925232f, -492.108154f, -395.807251f, 95.78882f, -220.62146f, -455.37558f, 360.291565f, -296.372131f, 272.488342f, 360.207947f);
            float b2 = (-98.31558f);
            bool3x4 r2 = bool3x4(true, false, false, true, true, false, true, true, false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x4 a3 = float3x4(389.727417f, -400.615234f, -85.46912f, -467.702148f, -51.38788f, 201.764648f, -47.8412781f, -180.740051f, -409.0157f, 229.699036f, 176.197876f, -410.45517f);
            float b3 = (68.7366943f);
            bool3x4 r3 = bool3x4(false, true, true, true, true, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float3x4 b0 = float3x4(-377.196533f, -505.147552f, 375.9267f, 110.17395f, -118.097565f, -40.4508972f, -299.744324f, 31.4371338f, -458.904541f, 13.6846924f, -458.5069f, 248.276489f);
            bool3x4 r0 = bool3x4(false, false, true, true, true, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (389.231445f);
            float3x4 b1 = float3x4(488.745544f, -221.637878f, -424.2672f, 249.059021f, -22.1361389f, -442.247742f, -340.857544f, -95.1117249f, 15.4094238f, 87.29248f, 495.067627f, 316.0185f);
            bool3x4 r1 = bool3x4(true, false, false, false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-125.568115f);
            float3x4 b2 = float3x4(122.164795f, 96.75537f, -228.906342f, -143.9527f, -230.238281f, -327.6126f, 103.39801f, 434.488831f, -157.4502f, 190.572144f, 108.2583f, 132.550781f);
            bool3x4 r2 = bool3x4(true, true, false, false, false, false, true, true, false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-431.515228f);
            float3x4 b3 = float3x4(-192.203522f, -431.835f, -85.58124f, 328.670532f, 273.577881f, -178.669067f, 352.6363f, -82.6058044f, 238.908875f, 291.335327f, 183.357361f, -185.0326f);
            bool3x4 r3 = bool3x4(true, false, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_wide_wide()
        {
            float3x4 a0 = float3x4(-229.29068f, 505.536621f, -73.80707f, 100.292053f, -419.214783f, -159.559753f, -396.770355f, 127.037415f, 489.1399f, 51.9188843f, 155.384766f, -135.631653f);
            float3x4 b0 = float3x4(-445.845032f, -420.035278f, 299.0244f, -13.8809814f, 151.5617f, -163.50943f, -391.096039f, 479.283752f, -77.6748657f, -46.584198f, -415.377f, 71.46698f);
            bool3x4 r0 = bool3x4(true, true, false, true, false, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x4 a1 = float3x4(-425.978149f, -228.430511f, 383.03833f, 136.533569f, 8.602417f, -251.324371f, -345.954926f, -170.565918f, -293.2544f, 139.125f, 214.3031f, 238.7699f);
            float3x4 b1 = float3x4(-206.061035f, 360.8363f, 236.968811f, 14.550354f, 364.735168f, -159.06131f, 226.631165f, 182.796021f, 341.839355f, -79.13046f, -247.296814f, 164.589111f);
            bool3x4 r1 = bool3x4(false, false, true, true, false, false, false, false, false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x4 a2 = float3x4(105.535217f, -170.9253f, 26.9802246f, -188.928314f, 201.786621f, -506.057159f, 15.454895f, 115.080688f, -496.971832f, 339.888123f, 372.228333f, 313.2387f);
            float3x4 b2 = float3x4(-352.1598f, 9.822632f, 186.721619f, -325.913635f, -77.93036f, -379.746033f, 251.45575f, -144.183563f, 337.8899f, -249.505554f, -225.9013f, -249.491272f);
            bool3x4 r2 = bool3x4(true, false, false, true, true, false, false, true, false, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x4 a3 = float3x4(-419.108948f, -265.329773f, -42.5019836f, 369.163879f, 67.16907f, -256.6989f, -104.105927f, 499.570129f, 41.6635132f, 151.1521f, 220.688354f, -344.658875f);
            float3x4 b3 = float3x4(381.122864f, 325.5454f, 455.49884f, 333.318665f, 118.980347f, 223.19812f, -385.289063f, 333.8808f, -437.4107f, 243.975464f, -302.8199f, -32.7101746f);
            bool3x4 r3 = bool3x4(false, false, false, true, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_wide_scalar()
        {
            float3x4 a0 = float3x4(11.156311f, -411.023224f, 385.885559f, -485.103058f, -491.180023f, 405.175354f, 173.575073f, 69.26929f, 501.306824f, -367.027771f, -86.12451f, -489.090576f);
            float b0 = (-302.816956f);
            bool3x4 r0 = bool3x4(true, false, true, false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x4 a1 = float3x4(-172.518158f, -236.414948f, -238.8945f, -27.2391357f, 471.779358f, 240.164551f, -481.4781f, 185.59436f, 33.29474f, -510.228149f, -183.2862f, -386.127655f);
            float b1 = (-18.1496277f);
            bool3x4 r1 = bool3x4(false, false, false, false, true, true, false, true, true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x4 a2 = float3x4(-13.6382141f, -261.865967f, 52.24951f, 16.3232422f, -410.5101f, -262.2675f, -458.255981f, -218.866119f, -34.6923523f, 290.573059f, 180.2633f, -482.863953f);
            float b2 = (-7.34790039f);
            bool3x4 r2 = bool3x4(false, false, true, true, false, false, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x4 a3 = float3x4(100.7063f, 501.319763f, -289.280975f, -25.8497f, 455.1624f, -63.3173523f, -17.4467773f, 53.01776f, 88.81958f, 182.357971f, -428.927216f, 408.336853f);
            float b3 = (180.672546f);
            bool3x4 r3 = bool3x4(false, true, false, false, true, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float3x4 b0 = float3x4(-226.2044f, -423.465f, 409.405518f, 453.877075f, 87.47571f, 113.795593f, 176.409241f, -140.440033f, -182.48288f, -158.2933f, -162.685333f, -193.328674f);
            bool3x4 r0 = bool3x4(true, true, true, false, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (230.181274f);
            float3x4 b1 = float3x4(-102.58783f, 392.520569f, -177.478668f, -10.2950134f, -24.04895f, 172.448669f, 374.048035f, -368.99762f, -210.195282f, 149.470215f, -281.343262f, -100.469177f);
            bool3x4 r1 = bool3x4(true, false, true, true, true, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (304.864441f);
            float3x4 b2 = float3x4(-361.524841f, -372.452362f, -33.9095459f, -69.5952759f, -460.4324f, -309.341675f, 486.131531f, 471.920959f, 479.361572f, -107.004181f, 331.636536f, -340.840149f);
            bool3x4 r2 = bool3x4(true, true, true, true, true, true, false, false, false, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-384.2146f);
            float3x4 b3 = float3x4(-451.726563f, 467.97876f, -236.569122f, 44.6547241f, -285.797852f, 42.730957f, 338.18512f, 274.017029f, -108.60437f, -211.37326f, -19.00415f, 194.114685f);
            bool3x4 r3 = bool3x4(true, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_equal_wide_wide()
        {
            float3x4 a0 = float3x4(240.090515f, 462.213135f, 293.08252f, -427.870667f, -405.5227f, 204.591919f, 294.6701f, -327.564453f, -456.12326f, 282.30127f, 421.881165f, -311.71283f);
            float3x4 b0 = float3x4(-81.20383f, 493.637451f, -411.4721f, 99.16443f, -295.6677f, -480.462555f, 74.41406f, 260.916138f, 306.173279f, 139.564819f, -505.752472f, -489.6268f);
            bool3x4 r0 = bool3x4(false, true, false, true, true, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x4 a1 = float3x4(84.5675049f, 447.244629f, -154.494354f, -424.364746f, 36.68451f, 267.0703f, 307.893921f, -351.760132f, -157.360352f, 152.709045f, 372.267151f, 202.368286f);
            float3x4 b1 = float3x4(-280.0326f, 303.1599f, 511.1902f, -104.659729f, 95.14661f, -125.636353f, 376.2398f, -415.774719f, -47.48105f, 117.722107f, 469.378357f, -263.042358f);
            bool3x4 r1 = bool3x4(false, false, true, true, true, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x4 a2 = float3x4(-77.04346f, 438.1848f, 260.282349f, 386.034058f, -281.491f, -102.930054f, -346.716736f, -258.3412f, -383.302948f, -5.14703369f, 319.34375f, 465.022217f);
            float3x4 b2 = float3x4(-216.002319f, 66.73425f, 99.21863f, 233.843018f, 439.839966f, 61.1151123f, -219.030579f, -404.7129f, -202.748352f, -312.476471f, 310.0719f, -320.363037f);
            bool3x4 r2 = bool3x4(false, false, false, false, true, true, true, false, true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x4 a3 = float3x4(145.933472f, -215.074829f, -146.461517f, -349.893982f, 29.5991211f, -131.796631f, -438.9947f, 147.057922f, 221.112488f, -356.145355f, -32.83017f, 442.942017f);
            float3x4 b3 = float3x4(186.075989f, -42.6377869f, 82.56506f, 127.189087f, 198.286987f, -450.492035f, 20.901001f, 449.465881f, -478.7727f, 380.053955f, 99.1247559f, -450.329773f);
            bool3x4 r3 = bool3x4(true, true, true, true, true, false, true, true, false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_equal_wide_scalar()
        {
            float3x4 a0 = float3x4(309.192444f, 69.67377f, -101.724182f, -315.9724f, -346.011047f, 424.15387f, -410.870056f, -483.902649f, 183.821167f, 320.4425f, -257.870056f, -386.801758f);
            float b0 = (292.924255f);
            bool3x4 r0 = bool3x4(false, true, true, true, true, false, true, true, true, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x4 a1 = float3x4(-182.938812f, 485.311584f, 373.5691f, 259.1515f, 450.130066f, -128.525543f, -43.8748779f, 457.385742f, -77.6383057f, 479.451843f, -499.516449f, -398.132935f);
            float b1 = (349.250122f);
            bool3x4 r1 = bool3x4(true, false, false, true, false, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x4 a2 = float3x4(402.484863f, -502.1736f, 125.950806f, -54.49362f, 250.667419f, 97.94293f, 228.021545f, -213.378662f, 42.2608032f, -24.8275757f, -451.0416f, 429.577576f);
            float b2 = (87.91608f);
            bool3x4 r2 = bool3x4(false, true, false, true, false, false, false, true, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x4 a3 = float3x4(-308.4343f, -279.4071f, 181.672241f, -290.148743f, -184.844086f, 447.6939f, 168.8866f, 26.3789673f, 392.558533f, 255.604858f, 162.163452f, 195.496277f);
            float b3 = (355.160339f);
            bool3x4 r3 = bool3x4(true, true, true, true, true, false, true, true, false, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float3x4 b0 = float3x4(51.1589966f, 340.443665f, 312.81427f, 354.1925f, 136.396729f, -94.76788f, 288.5443f, 304.042847f, -148.618073f, -506.3001f, 27.5812378f, 48.47113f);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (104.883484f);
            float3x4 b1 = float3x4(-488.685852f, -480.435181f, 421.936646f, 239.721069f, -101.018433f, -283.951477f, -55.24353f, -455.80484f, 131.107239f, -461.6988f, -388.482849f, -258.936035f);
            bool3x4 r1 = bool3x4(false, false, true, true, false, false, false, false, true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-225.223541f);
            float3x4 b2 = float3x4(-116.019989f, -442.595245f, 297.333374f, 36.6872559f, 485.097839f, 344.445679f, 237.592163f, 230.390869f, -413.9848f, -215.901672f, 39.5603638f, 22.947998f);
            bool3x4 r2 = bool3x4(true, false, true, true, true, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-162.060577f);
            float3x4 b3 = float3x4(236.7337f, -253.951965f, -204.719086f, -161.616547f, -64.3859253f, -229.815643f, -484.825653f, -135.040436f, 351.694763f, 111.825378f, -249.982544f, 435.8073f);
            bool3x4 r3 = bool3x4(true, false, false, true, true, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_equal_wide_wide()
        {
            float3x4 a0 = float3x4(-386.5918f, -157.120789f, 391.015259f, -511.886871f, -5.42202759f, 287.645264f, -122.535187f, 7.48144531f, 152.946411f, 48.9862061f, 57.3381348f, 300.4649f);
            float3x4 b0 = float3x4(153.443f, 49.8924561f, 78.02582f, 138.813721f, -225.51059f, -339.3561f, -373.302063f, 364.9359f, -322.7154f, 125.47821f, -25.77658f, 297.518921f);
            bool3x4 r0 = bool3x4(false, false, true, false, true, true, true, false, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x4 a1 = float3x4(349.25708f, 85.7496948f, -230.953308f, 418.711243f, -131.039917f, -126.512207f, -156.818481f, 422.3775f, -413.089325f, 219.442749f, 35.5911255f, 447.181519f);
            float3x4 b1 = float3x4(73.22235f, 462.783752f, 393.191345f, -95.0014343f, 381.357056f, 93.03192f, 254.253235f, 90.67279f, 348.938171f, 161.337646f, 79.43561f, 420.243469f);
            bool3x4 r1 = bool3x4(true, false, false, true, false, false, false, true, false, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x4 a2 = float3x4(-223.492981f, 302.123f, 459.852722f, -347.128021f, 364.9781f, 212.635437f, 504.276062f, -142.232971f, -132.2218f, 303.683777f, 265.210144f, 9.754395f);
            float3x4 b2 = float3x4(453.684875f, -154.011658f, -97.29007f, 151.184753f, 57.36029f, -194.207092f, -462.670624f, 113.3866f, -129.3533f, 8.107788f, 426.449524f, 410.693176f);
            bool3x4 r2 = bool3x4(false, true, true, false, true, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x4 a3 = float3x4(-233.0929f, 26.5675049f, 266.7807f, -250.072235f, 138.040833f, 174.276733f, -420.931641f, -42.8541565f, 216.485046f, 240.053833f, -470.382172f, 98.39673f);
            float3x4 b3 = float3x4(470.313416f, 220.399963f, -372.872681f, -242.178558f, 177.506226f, -172.638153f, 60.72284f, 478.250183f, 234.30304f, 297.821228f, 104.584595f, -462.418732f);
            bool3x4 r3 = bool3x4(false, false, true, false, false, true, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_equal_wide_scalar()
        {
            float3x4 a0 = float3x4(495.4574f, -14.3451233f, -463.4748f, 217.517517f, -246.865723f, -377.6587f, 53.8151245f, -123.332947f, -221.505463f, 252.994324f, -116.440369f, -395.3633f);
            float b0 = (189.205139f);
            bool3x4 r0 = bool3x4(true, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x4 a1 = float3x4(164.772583f, 355.837036f, 184.195557f, 273.012268f, -418.1424f, 249.3841f, 396.392151f, 332.6654f, 243.761414f, -335.12146f, -302.0869f, 254.442261f);
            float b1 = (-287.007324f);
            bool3x4 r1 = bool3x4(true, true, true, true, false, true, true, true, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x4 a2 = float3x4(179.005066f, -331.271667f, 307.890564f, -388.578522f, 150.605774f, -219.892578f, -491.681f, 30.99707f, 199.232239f, -74.50003f, -343.386475f, 216.031555f);
            float b2 = (71.1767f);
            bool3x4 r2 = bool3x4(true, false, true, false, true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x4 a3 = float3x4(-420.403137f, -336.6411f, 317.0946f, -262.424927f, -228.411255f, 123.465454f, 264.102478f, 223.623352f, 440.5354f, -420.727f, 74.8443f, -177.077881f);
            float b3 = (-78.38403f);
            bool3x4 r3 = bool3x4(false, false, true, false, false, true, true, true, true, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float3x4 b0 = float3x4(204.802979f, -101.104034f, -122.055023f, -70.45615f, -239.62027f, -185.992737f, -455.612579f, 276.665833f, 79.39917f, 416.420532f, 379.2735f, -439.5147f);
            bool3x4 r0 = bool3x4(true, true, true, true, true, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (67.14099f);
            float3x4 b1 = float3x4(-74.56064f, -367.256348f, 494.950745f, -61.2355347f, -429.170258f, -213.824677f, -264.310181f, 243.11377f, -22.38388f, 304.862f, -323.686157f, 67.93805f);
            bool3x4 r1 = bool3x4(true, true, false, true, true, true, true, false, true, false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (125.303589f);
            float3x4 b2 = float3x4(-400.47052f, -283.159637f, -42.31961f, -429.510376f, 499.395874f, -289.963074f, -136.008789f, -351.125244f, -381.8183f, 393.3009f, 18.02362f, -169.92392f);
            bool3x4 r2 = bool3x4(true, true, true, true, false, true, true, true, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-285.884949f);
            float3x4 b3 = float3x4(163.7511f, 191.855347f, 114.0155f, -395.98584f, 189.366577f, 176.19812f, 61.7138062f, 507.548462f, 224.043823f, -422.9937f, -127.054993f, 95.5286255f);
            bool3x4 r3 = bool3x4(false, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_add_wide_wide()
        {
            float3x4 a0 = float3x4(465.148376f, 278.9107f, -277.5299f, -65.1972046f, -473.324371f, -4.69555664f, -470.536774f, -109.9501f, -178.701447f, -420.033783f, 290.711121f, -446.529633f);
            float3x4 b0 = float3x4(483.9944f, -204.07666f, -365.673553f, -509.920868f, -270.6975f, 486.763977f, 267.49176f, 251.642517f, 244.495117f, -78.67575f, 352.2055f, 82.7791748f);
            float3x4 r0 = float3x4(949.142761f, 74.8340454f, -643.2035f, -575.118042f, -744.021851f, 482.06842f, -203.045013f, 141.692413f, 65.79367f, -498.709534f, 642.9166f, -363.750458f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x4 a1 = float3x4(491.066467f, -261.1173f, -298.4069f, 502.4286f, 284.5943f, 401.128418f, -36.26349f, -102.949158f, 503.198181f, -384.4291f, -45.22821f, -198.67395f);
            float3x4 b1 = float3x4(462.5473f, -405.492f, -428.498322f, -41.87259f, -269.9275f, 75.20447f, -141.913391f, -222.186768f, 41.3057251f, 148.339478f, -177.233124f, -176.51889f);
            float3x4 r1 = float3x4(953.6138f, -666.6093f, -726.9052f, 460.556f, 14.6668091f, 476.3329f, -178.17688f, -325.135925f, 544.5039f, -236.08963f, -222.461334f, -375.192841f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x4 a2 = float3x4(-62.8800049f, -79.5522461f, 413.098267f, -100.877594f, 418.524f, -183.143127f, 407.443726f, 300.486023f, -261.126129f, -309.830353f, 378.363342f, -224.094f);
            float3x4 b2 = float3x4(492.692444f, 439.043823f, -511.742767f, -399.057129f, -315.868469f, -228.07724f, -171.7052f, 467.17395f, -474.822937f, 311.390747f, 326.8454f, 475.2119f);
            float3x4 r2 = float3x4(429.812439f, 359.491577f, -98.6445f, -499.934723f, 102.655518f, -411.220367f, 235.738525f, 767.66f, -735.9491f, 1.56039429f, 705.20874f, 251.11792f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x4 a3 = float3x4(-164.555725f, -69.87393f, 224.634644f, -383.9926f, 149.221252f, 169.388f, 163.053955f, 57.0291138f, 342.950073f, 168.680481f, -470.770264f, -117.630493f);
            float3x4 b3 = float3x4(314.152954f, -262.594635f, -82.86911f, 156.299561f, 427.40155f, -279.099365f, -448.615234f, 284.3371f, 288.1856f, -232.39505f, -386.871918f, 162.903381f);
            float3x4 r3 = float3x4(149.597229f, -332.468567f, 141.765533f, -227.693054f, 576.6228f, -109.711365f, -285.561279f, 341.3662f, 631.1357f, -63.71457f, -857.6422f, 45.27289f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_add_wide_scalar()
        {
            float3x4 a0 = float3x4(459.898315f, -447.663361f, -94.43863f, 126.429871f, -36.254364f, -349.6413f, -2.79125977f, -478.4148f, 443.115234f, 268.092224f, 41.3210449f, -471.256073f);
            float b0 = (500.997253f);
            float3x4 r0 = float3x4(960.895569f, 53.3338928f, 406.558624f, 627.4271f, 464.7429f, 151.355957f, 498.206f, 22.5824585f, 944.1125f, 769.0895f, 542.3183f, 29.74118f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x4 a1 = float3x4(-2.664978f, 202.14801f, 311.725464f, 10.3458252f, -151.244446f, 355.2328f, -197.800751f, 255.955261f, 244.1471f, -181.626556f, -2.45492554f, 300.900635f);
            float b1 = (78.98584f);
            float3x4 r1 = float3x4(76.32086f, 281.13385f, 390.7113f, 89.331665f, -72.258606f, 434.218628f, -118.814911f, 334.9411f, 323.132935f, -102.640717f, 76.5309143f, 379.886475f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x4 a2 = float3x4(-236.491943f, -172.5422f, -242.9411f, 466.344116f, 237.987488f, 264.294f, 372.866821f, -198.837769f, -381.930969f, 402.160339f, -117.024841f, 497.373779f);
            float b2 = (-160.5841f);
            float3x4 r2 = float3x4(-397.07605f, -333.1263f, -403.5252f, 305.76f, 77.40338f, 103.7099f, 212.282715f, -359.421875f, -542.5151f, 241.576233f, -277.608948f, 336.789673f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x4 a3 = float3x4(485.9093f, 77.81482f, -271.547974f, -133.2518f, 211.86676f, 253.1502f, -342.783173f, -185.248352f, -403.3855f, -358.848236f, 65.24756f, 127.201721f);
            float b3 = (-47.75714f);
            float3x4 r3 = float3x4(438.152161f, 30.0576782f, -319.3051f, -181.008942f, 164.109619f, 205.393066f, -390.5403f, -233.0055f, -451.142639f, -406.605377f, 17.4904175f, 79.44458f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float3x4 b0 = float3x4(-264.088135f, -106.009247f, -355.4473f, -447.3303f, -158.7002f, -199.4837f, 180.318115f, 337.579346f, -37.0550232f, 230.805f, -140.174347f, 18.02417f);
            float3x4 r0 = float3x4(-589.6009f, -431.522f, -680.9601f, -772.843f, -484.212952f, -524.99646f, -145.194641f, 12.0665894f, -362.56778f, -94.70776f, -465.6871f, -307.4886f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-138.614349f);
            float3x4 b1 = float3x4(26.9041748f, -374.5376f, 154.46759f, 268.38385f, -190.963013f, 188.617249f, -504.916138f, 20.45404f, 197.945374f, 251.411926f, -421.0904f, 111.445374f);
            float3x4 r1 = float3x4(-111.710175f, -513.152f, 15.853241f, 129.7695f, -329.577362f, 50.0029f, -643.5305f, -118.160309f, 59.3310242f, 112.797577f, -559.7047f, -27.1689758f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-73.26889f);
            float3x4 b2 = float3x4(480.884583f, 438.05304f, 66.8443f, -270.796021f, -44.02191f, 197.6947f, 19.1139526f, 349.2378f, 366.2345f, -413.4803f, -260.720184f, 77.54236f);
            float3x4 r2 = float3x4(407.6157f, 364.784149f, -6.424591f, -344.0649f, -117.2908f, 124.425812f, -54.1549377f, 275.9689f, 292.9656f, -486.749176f, -333.989075f, 4.273468f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (183.9549f);
            float3x4 b3 = float3x4(-51.4989929f, -472.497467f, 107.126892f, 349.0772f, 431.595947f, -314.110962f, 396.996643f, -167.308624f, -157.114532f, 287.7625f, -367.33905f, 96.23682f);
            float3x4 r3 = float3x4(132.4559f, -288.542572f, 291.0818f, 533.0321f, 615.550842f, -130.156067f, 580.951538f, 16.64627f, 26.8403625f, 471.7174f, -183.384155f, 280.1917f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_sub_wide_wide()
        {
            float3x4 a0 = float3x4(133.371033f, -131.832123f, -197.293152f, -485.28656f, -337.550323f, 471.6671f, 146.506592f, -130.585052f, 110.7771f, -235.5416f, 78.87933f, -347.686157f);
            float3x4 b0 = float3x4(123.460266f, 359.56012f, -48.2484741f, 478.979065f, 207.158325f, 142.36731f, -125.6055f, -65.29901f, -477.876434f, 164.5f, 428.009583f, 72.62781f);
            float3x4 r0 = float3x4(9.910767f, -491.392242f, -149.044678f, -964.2656f, -544.7086f, 329.2998f, 272.1121f, -65.28604f, 588.653564f, -400.0416f, -349.130249f, -420.313965f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x4 a1 = float3x4(-470.820557f, -11.45929f, -167.9479f, 330.676758f, -508.350861f, -252.031891f, -427.9342f, 192.6576f, 168.429321f, 457.308777f, 470.058533f, -299.711884f);
            float3x4 b1 = float3x4(-446.8805f, 432.091431f, -225.554657f, -112.451965f, -210.6128f, -172.925049f, -80.60748f, 270.046082f, -154.255585f, 148.475769f, 13.6611328f, 70.67108f);
            float3x4 r1 = float3x4(-23.9400635f, -443.55072f, 57.60675f, 443.128723f, -297.738068f, -79.10684f, -347.326721f, -77.38849f, 322.6849f, 308.833f, 456.3974f, -370.382965f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x4 a2 = float3x4(-308.939575f, 454.5334f, 26.1069336f, -482.711823f, -40.8535461f, 318.380676f, 475.210815f, 134.926941f, 388.481567f, 138.7182f, -385.5736f, -149.3648f);
            float3x4 b2 = float3x4(-221.325439f, -9.25882f, 288.173828f, 217.36145f, 307.540039f, -262.412659f, -405.378021f, 400.004333f, 72.11908f, -154.880585f, -469.659973f, -320.615417f);
            float3x4 r2 = float3x4(-87.6141357f, 463.7922f, -262.0669f, -700.073242f, -348.3936f, 580.793335f, 880.588867f, -265.0774f, 316.3625f, 293.5988f, 84.0863647f, 171.25061f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x4 a3 = float3x4(-158.534058f, 508.070679f, 482.7008f, 114.569275f, 364.83136f, 229.031f, -168.088074f, 373.4411f, -239.90097f, 379.928467f, 113.011841f, 306.835266f);
            float3x4 b3 = float3x4(6.41229248f, -278.865051f, 15.8380737f, 27.51831f, 429.869629f, -458.622467f, -172.064423f, -284.524719f, 42.60669f, -223.474243f, -56.92975f, 61.807312f);
            float3x4 r3 = float3x4(-164.94635f, 786.9357f, 466.862732f, 87.0509644f, -65.03827f, 687.653442f, 3.97634888f, 657.9658f, -282.50766f, 603.4027f, 169.941589f, 245.027954f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_sub_wide_scalar()
        {
            float3x4 a0 = float3x4(48.9367065f, 410.4516f, -364.4417f, 163.980591f, -460.067322f, 110.919434f, 204.358337f, 180.269714f, -377.9257f, -470.262054f, 400.5349f, 461.507568f);
            float b0 = (-291.5904f);
            float3x4 r0 = float3x4(340.5271f, 702.042f, -72.85132f, 455.570984f, -168.476929f, 402.509827f, 495.94873f, 471.8601f, -86.3353f, -178.671661f, 692.1253f, 753.097961f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x4 a1 = float3x4(-246.287262f, 246.350708f, -121.427368f, -122.718414f, -122.938721f, 360.15094f, 342.874573f, 18.92981f, 164.602356f, 97.0437f, 485.914978f, -205.75766f);
            float b1 = (21.6052856f);
            float3x4 r1 = float3x4(-267.892548f, 224.745422f, -143.032654f, -144.3237f, -144.544f, 338.545654f, 321.2693f, -2.675476f, 142.99707f, 75.4384155f, 464.3097f, -227.362946f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x4 a2 = float3x4(253.443237f, 187.998413f, -450.820282f, -248.073364f, -26.9960632f, 441.5526f, 449.910583f, 354.886047f, 98.82147f, -189.193237f, 269.074829f, -59.11856f);
            float b2 = (-121.163055f);
            float3x4 r2 = float3x4(374.6063f, 309.161469f, -329.657227f, -126.910309f, 94.16699f, 562.7157f, 571.0736f, 476.0491f, 219.984528f, -68.03018f, 390.237885f, 62.0444946f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x4 a3 = float3x4(363.458374f, -46.1552124f, 109.913269f, 182.646912f, 229.015747f, -144.92868f, 469.2506f, -150.49231f, -192.3125f, -224.356842f, 285.876831f, -63.0108337f);
            float b3 = (-73.7792053f);
            float3x4 r3 = float3x4(437.237579f, 27.6239929f, 183.692474f, 256.426117f, 302.794952f, -71.1494751f, 543.0298f, -76.7131042f, -118.533295f, -150.577637f, 359.656036f, 10.7683716f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float3x4 b0 = float3x4(452.352539f, 256.9898f, -275.159882f, -89.02753f, 488.2284f, -333.2173f, -64.233f, -66.04172f, 341.204956f, -385.775055f, 75.3947754f, 354.943726f);
            float3x4 r0 = float3x4(-157.766052f, 37.59668f, 569.746338f, 383.614f, -193.6419f, 627.8038f, 358.8195f, 360.6282f, -46.61847f, 680.3616f, 219.191711f, -60.35724f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (169.131409f);
            float3x4 b1 = float3x4(88.21661f, 1.73498535f, 122.538025f, -264.945f, -50.83719f, -347.65033f, 4.06555176f, -79.09543f, 354.358337f, -292.4925f, -53.2089844f, -246.3476f);
            float3x4 r1 = float3x4(80.9147949f, 167.396423f, 46.5933838f, 434.076416f, 219.9686f, 516.781738f, 165.065857f, 248.226837f, -185.226929f, 461.6239f, 222.3404f, 415.479f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (299.203369f);
            float3x4 b2 = float3x4(432.1847f, -163.88f, 176.742554f, -104.98584f, -445.797638f, -28.8731689f, -169.588226f, -270.359253f, 68.04761f, -65.53128f, 440.380371f, 427.360657f);
            float3x4 r2 = float3x4(-132.981323f, 463.083374f, 122.460815f, 404.1892f, 745.001f, 328.076538f, 468.7916f, 569.5626f, 231.155762f, 364.73465f, -141.177f, -128.157288f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-81.47296f);
            float3x4 b3 = float3x4(41.7131958f, 175.8208f, -214.949158f, -163.446869f, -218.829132f, 389.116882f, -74.10977f, -448.137238f, -410.375f, 363.211f, -263.5354f, 473.546021f);
            float3x4 r3 = float3x4(-123.186157f, -257.293762f, 133.4762f, 81.97391f, 137.356171f, -470.589844f, -7.3631897f, 366.664276f, 328.902039f, -444.68396f, 182.062439f, -555.019f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mul_wide_wide()
        {
            float3x4 a0 = float3x4(-394.780548f, -412.3722f, -25.8745728f, -241.045959f, -93.6759949f, 244.159973f, 494.688477f, 53.5379639f, -239.4964f, 236.675842f, -211.8562f, -216.654816f);
            float3x4 b0 = float3x4(-149.763977f, -345.04538f, -284.334045f, 267.979248f, -326.6485f, -150.689667f, 207.732422f, 366.192871f, 358.880737f, 214.853577f, 253.422791f, -307.7138f);
            float3x4 r0 = float3x4(59123.9063f, 142287.125f, 7357.022f, -64595.3164f, 30599.123f, -36792.3867f, 102762.836f, 19605.22f, -85950.64f, 50850.6523f, -53689.19f, 66667.68f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x4 a1 = float3x4(467.9583f, -178.021912f, -386.394257f, -422.4354f, 464.589539f, -251.315674f, -104.97879f, -66.93417f, -39.829895f, 401.5656f, 434.146179f, -336.4542f);
            float3x4 b1 = float3x4(184.47113f, 426.436462f, -144.281433f, 459.4796f, -358.313354f, -201.3652f, 254.909973f, 168.520935f, 8.794556f, -194.846466f, -405.362671f, -180.732178f);
            float3x4 r1 = float3x4(86324.8f, -75915.03f, 55749.5156f, -194100.453f, -166468.641f, 50606.23f, -26760.14f, -11279.81f, -350.286224f, -78243.64f, -175986.656f, 60808.0977f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x4 a2 = float3x4(-83.11417f, 329.960266f, -316.972168f, 474.937927f, -445.109161f, -301.003723f, 405.687866f, 142.373474f, -416.213074f, -103.279205f, -52.9519043f, -40.82834f);
            float3x4 b2 = float3x4(-189.746918f, -35.5184631f, 120.31665f, -136.203339f, 407.3416f, 301.6543f, -155.482391f, -461.394562f, 296.680359f, 341.001831f, -257.0968f, 17.5936279f);
            float3x4 r2 = float3x4(15770.6572f, -11719.6816f, -38137.03f, -64688.1328f, -181311.484f, -90799.07f, -63077.32f, -65690.34f, -123482.242f, -35218.4f, 13613.7656f, -718.3186f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x4 a3 = float3x4(-86.18509f, -257.316528f, 363.857239f, -229.860016f, 8.925293f, -2.44940186f, 37.7583f, 264.451782f, -321.251282f, -268.256042f, 43.9136963f, 274.833069f);
            float3x4 b3 = float3x4(-443.845123f, 291.349243f, 490.19165f, 361.320984f, -509.289734f, 315.352661f, 125.083069f, -167.727112f, 396.8877f, -0.320404053f, 143.4115f, -396.3475f);
            float3x4 r3 = float3x4(38252.832f, -74968.98f, 178359.781f, -83053.25f, -4545.56f, -772.4254f, 4722.92432f, -44355.7344f, -127500.68f, 85.950325f, 6297.729f, -108929.4f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mul_wide_scalar()
        {
            float3x4 a0 = float3x4(328.203f, -290.10672f, 236.995728f, 120.481384f, 357.903137f, 134.867249f, -477.3105f, -438.272919f, -46.729187f, -238.405f, 422.08252f, -48.83484f);
            float b0 = (192.211182f);
            float3x4 r0 = float3x4(63084.2852f, -55761.7539f, 45553.23f, 23157.87f, 68792.9844f, 25922.9941f, -91744.4141f, -84240.95f, -8981.872f, -45824.1055f, 81128.98f, -9386.603f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x4 a1 = float3x4(355.30835f, -196.995819f, 98.23602f, -325.552155f, 53.9373169f, -87.45099f, -130.474121f, -222.594574f, 126.015015f, 293.361084f, 174.381958f, -327.120056f);
            float b1 = (119.356628f);
            float3x4 r1 = float3x4(42408.4063f, -23512.7559f, 11725.12f, -38856.81f, 6437.77637f, -10437.8555f, -15572.9512f, -26568.1387f, 15040.7275f, 35014.59f, 20813.6426f, -39043.9453f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x4 a2 = float3x4(56.62915f, -475.6087f, -452.6919f, -49.22061f, 141.600952f, 431.5857f, 180.355164f, -40.9234619f, 279.543518f, 120.014465f, -59.508667f, 319.489868f);
            float b2 = (257.541565f);
            float3x4 r2 = float3x4(14584.36f, -122489.008f, -116586.977f, -12676.3535f, 36468.13f, 111151.258f, 46448.95f, -10539.4922f, 71994.08f, 30908.7129f, -15325.9551f, 82281.92f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x4 a3 = float3x4(-403.523163f, -335.3932f, -364.242554f, 150.686157f, 391.87207f, 179.312439f, 354.5298f, 497.7614f, 418.436584f, -413.333374f, -329.520721f, -322.703064f);
            float b3 = (-408.1931f);
            float3x4 r3 = float3x4(164715.375f, 136905.188f, 148681.3f, -61509.05f, -159959.484f, -73194.1f, -144716.625f, -203182.781f, -170802.938f, 168719.844f, 134508.1f, 131725.172f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float3x4 b0 = float3x4(329.360962f, -198.683441f, 184.0794f, 256.016174f, 266.226318f, -97.8947449f, 159.748108f, -351.8222f, 491.801575f, 49.90204f, 424.4626f, 160.1181f);
            float3x4 r0 = float3x4(-152999.6f, 92295.35f, -85511.27f, -118928.4f, -123671.359f, 45475.5039f, -74208.54f, 163433.625f, -228458.891f, -23181.2285f, -197177.6f, -74380.4141f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-395.9921f);
            float3x4 b1 = float3x4(125.20166f, -265.0158f, 314.656128f, -292.712036f, -37.72989f, 165.362244f, 356.517761f, -188.813324f, 504.9157f, 40.5721436f, -206.775116f, -61.60269f);
            float3x4 r1 = float3x4(-49578.8672f, 104944.164f, -124601.336f, 115911.656f, 14940.7373f, -65482.14f, -141178.219f, 74768.5859f, -199942.625f, -16066.248f, 81881.31f, 24394.18f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (118.971619f);
            float3x4 b2 = float3x4(53.7483521f, -198.6694f, 96.236084f, -20.2418823f, -31.1239624f, 38.89044f, -13.1333008f, 507.871277f, 95.0179443f, 340.7486f, 438.986877f, -227.165955f);
            float3x4 r2 = float3x4(6394.52832f, -23636.02f, 11449.3623f, -2408.20947f, -3702.86816f, 4626.859f, -1562.49011f, 60422.27f, 11304.4385f, 40539.41f, 52226.98f, -27026.3f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (452.573f);
            float3x4 b3 = float3x4(144.014954f, -31.58603f, 42.29773f, -466.027161f, 287.453979f, 328.9969f, -164.243134f, -511.2683f, -9.594299f, 431.190125f, -132.141815f, -87.502655f);
            float3x4 r3 = float3x4(65177.28f, -14294.9834f, 19142.81f, -210911.313f, 130093.906f, 148895.109f, -74332.01f, -231386.234f, -4342.12061f, 195145f, -59803.8164f, -39601.34f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_div_wide_wide()
        {
            float3x4 a0 = float3x4(246.265747f, -269.85614f, -451.619537f, -7.388489f, -308.205566f, -373.3948f, 360.41864f, 25.8097534f, -274.050476f, 127.538574f, -447.671753f, -137.458588f);
            float3x4 b0 = float3x4(172.119812f, -77.14111f, -325.8354f, -450.608673f, -261.262146f, -122.449493f, -93.2107849f, -442.005219f, 484.362732f, -390.7818f, 402.02533f, 316.6507f);
            float3x4 r0 = float3x4(1.43078089f, 3.49821424f, 1.38603592f, 0.0163966864f, 1.17967939f, 3.04937816f, -3.86670542f, -0.0583924167f, -0.565795958f, -0.326367736f, -1.11354113f, -0.434101641f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x4 a1 = float3x4(-136.133179f, 12.4376221f, 228.513f, 356.972351f, -24.7620544f, 411.6684f, -204.078888f, 11.3654175f, 82.15228f, 37.3894653f, 394.2658f, -429.912781f);
            float3x4 b1 = float3x4(397.154419f, -303.2622f, -118.591248f, -81.6503f, -84.34686f, -488.419434f, 404.160522f, -136.728851f, -19.8327026f, -102.607239f, 166.116028f, -112.840179f);
            float3x4 r1 = float3x4(-0.3427714f, -0.0410127677f, -1.926896f, -4.37196636f, 0.2935741f, -0.8428584f, -0.504945159f, -0.0831237659f, -4.14226341f, -0.364394039f, 2.37343621f, 3.80992651f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x4 a2 = float3x4(315.37384f, -122.665985f, 447.526123f, -210.4815f, -202.42157f, -453.007935f, 173.72699f, -167.121674f, -106.234528f, 414.312561f, 7.12084961f, 274.073669f);
            float3x4 b2 = float3x4(-218.209686f, 458.517517f, 119.587219f, 356.240417f, -74.50687f, -336.773926f, -216.126312f, 322.385681f, 220.2555f, -67.2345f, 2.229187f, -166.210968f);
            float3x4 r2 = float3x4(-1.44527888f, -0.267527372f, 3.742257f, -0.5908412f, 2.71681762f, 1.34513962f, -0.803821564f, -0.5183905f, -0.482324064f, -6.16220236f, 3.19437075f, -1.64895058f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x4 a3 = float3x4(-39.0026855f, 39.065918f, -147.364166f, 434.3849f, 315.0672f, -106.636017f, -507.925262f, -17.1764526f, -385.865356f, 226.002136f, 345.168457f, 201.544189f);
            float3x4 b3 = float3x4(-247.732574f, 84.16095f, 477.148621f, 209.7508f, -386.7222f, -65.27734f, 410.454834f, 367.6507f, -456.572021f, 382.427979f, -163.860687f, -213.721375f);
            float3x4 r3 = float3x4(0.157438666f, 0.464181036f, -0.3088433f, 2.07095718f, -0.814712f, 1.6335839f, -1.23746932f, -0.0467194878f, 0.8451358f, 0.5909665f, -2.106475f, -0.9430231f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_div_wide_scalar()
        {
            float3x4 a0 = float3x4(-244.517456f, 69.1123047f, -333.023132f, 257.396851f, 403.2456f, 154.34436f, 131.526611f, -261.8864f, -348.9238f, -275.5387f, 210.557922f, 287.6424f);
            float b0 = (-60.0243835f);
            float3x4 r0 = float3x4(4.07363558f, -1.15140378f, 5.548131f, -4.28820467f, -6.71803f, -2.571361f, -2.19121981f, 4.36300039f, 5.813034f, 4.590446f, -3.507873f, -4.79209232f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x4 a1 = float3x4(504.372253f, -26.6315918f, -253.236664f, 272.895142f, 178.096191f, -460.87558f, -502.646027f, -84.3248f, -174.690338f, 83.7963257f, 197.042053f, 317.168274f);
            float b1 = (491.7871f);
            float3x4 r1 = float3x4(1.02559066f, -0.0541526824f, -0.5149315f, 0.554905057f, 0.362140834f, -0.9371445f, -1.02208054f, -0.171466067f, -0.355215371f, 0.17039147f, 0.400665343f, 0.64493f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x4 a2 = float3x4(403.387146f, 60.6068726f, -413.5605f, 207.341f, 358.562134f, 20.7490845f, -68.57712f, 310.702454f, 417.4049f, 147.866211f, 506.658875f, -435.778564f);
            float b2 = (81.6464844f);
            float3x4 r2 = float3x4(4.940655f, 0.742308438f, -5.06525755f, 2.539497f, 4.391642f, 0.254133224f, -0.8399274f, 3.80546021f, 5.112344f, 1.81105423f, 6.20551968f, -5.33738327f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x4 a3 = float3x4(210.672913f, -19.1908569f, 416.511719f, 427.0136f, 417.1994f, -150.911835f, 488.985535f, -294.738739f, -357.298035f, 288.771667f, 453.429138f, 70.72443f);
            float b3 = (-218.781464f);
            float3x4 r3 = float3x4(-0.962937653f, 0.08771701f, -1.90377975f, -1.95178151f, -1.90692294f, 0.689783454f, -2.235041f, 1.34718335f, 1.63312757f, -1.31990921f, -2.07252073f, -0.323265165f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float3x4 b0 = float3x4(-422.676147f, 248.129639f, 449.391357f, 245.858154f, -326.6206f, 163.715088f, 333.6645f, 38.2910767f, -472.979767f, 192.230164f, -200.296875f, -490.181519f);
            float3x4 r0 = float3x4(-0.09874622f, 0.168209136f, 0.0928759947f, 0.169763222f, -0.1277864f, 0.2549409f, 0.125088736f, 1.0900104f, -0.0882440954f, 0.217123419f, -0.208379045f, -0.08514738f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-211.10257f);
            float3x4 b1 = float3x4(-322.852356f, -137.985291f, 84.32971f, 355.063477f, 276.427246f, -382.988037f, -488.647156f, 344.846f, 168.85498f, -44.1955872f, 420.55072f, -175.6152f);
            float3x4 r1 = float3x4(0.6538672f, 1.52989185f, -2.5033f, -0.5945488f, -0.7636822f, 0.55119884f, 0.432014316f, -0.612164736f, -1.25020039f, 4.776553f, -0.501966953f, 1.20207453f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-9.220581f);
            float3x4 b2 = float3x4(-344.194275f, -449.0715f, 117.704895f, -337.0274f, 239.393433f, -389.355164f, 242.716064f, 496.2765f, 91.74579f, -490.492126f, 485.755432f, -317.572266f);
            float3x4 r2 = float3x4(0.0267888848f, 0.0205325447f, -0.0783364251f, 0.02735855f, -0.038516432f, 0.0236816723f, -0.0379891656f, -0.018579524f, -0.100501411f, 0.0187986325f, -0.018981941f, 0.0290345922f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-451.6248f);
            float3x4 b3 = float3x4(394.018372f, -262.271423f, -314.246765f, 359.9159f, -101.615356f, 359.517273f, -424.9799f, -192.719574f, -169.749725f, -244.790009f, -187.14386f, -207.713654f);
            float3x4 r3 = float3x4(-1.14620233f, 1.72197485f, 1.43716609f, -1.2548064f, 4.444454f, -1.25619769f, 1.06269681f, 2.3434298f, 2.66053319f, 1.84494781f, 2.41324925f, 2.17426634f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mod_wide_wide()
        {
            float3x4 a0 = float3x4(-442.309875f, 368.5005f, -1.09390259f, -364.673828f, -197.343933f, -34.0349121f, -101.348572f, 208.318542f, -140.770325f, 183.44696f, -463.368378f, 83.83911f);
            float3x4 b0 = float3x4(-43.2450562f, -144.195862f, -62.6404724f, -336.828247f, -154.61026f, -154.029358f, 487.0462f, -469.8291f, -145.203766f, -203.384f, -22.52008f, 224.69f);
            float3x4 r0 = float3x4(-9.859314f, 80.1087646f, -1.09390259f, -27.8455811f, -42.7336731f, -34.0349121f, -101.348572f, 208.318542f, -140.770325f, 183.44696f, -12.9667664f, 83.83911f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x4 a1 = float3x4(-64.71405f, 295.066833f, 212.25708f, 349.6283f, 119.875916f, -37.8058167f, 142.41156f, 332.244263f, -464.194275f, -296.147827f, 225.175354f, -212.060272f);
            float3x4 b1 = float3x4(-435.62674f, 12.0955811f, 40.3787842f, 345.784851f, -433.471252f, -355.649963f, 4.015442f, 66.65979f, -221.853638f, -355.056763f, 357.935974f, 71.3753052f);
            float3x4 r1 = float3x4(-64.71405f, 4.772888f, 10.3631592f, 3.84344482f, 119.875916f, -37.8058167f, 1.87109375f, 65.6051f, -20.487f, -296.147827f, 225.175354f, -69.30966f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x4 a2 = float3x4(156.985718f, 507.6183f, 270.830444f, 337.7343f, 384.915833f, 432.5182f, 154.292725f, -37.0853271f, 7.76147461f, 238.094727f, 12.8520508f, -100.240662f);
            float3x4 b2 = float3x4(-131.4183f, -473.9876f, 76.2178345f, 92.2102051f, -368.189575f, -77.46716f, 135.230591f, 274.277283f, 132.180237f, -179.877319f, 51.9685669f, 367.214233f);
            float3x4 r2 = float3x4(25.5674133f, 33.6306763f, 42.17694f, 61.1037f, 16.7262573f, 45.182373f, 19.0621338f, -37.0853271f, 7.76147461f, 58.2174072f, 12.8520508f, -100.240662f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x4 a3 = float3x4(34.552002f, -251.189758f, -238.372253f, 511.514648f, 288.433533f, 367.109863f, 44.760437f, -437.0456f, -259.2056f, -228.565826f, 83.49725f, 424.367065f);
            float3x4 b3 = float3x4(-395.2128f, 270.485229f, -73.104126f, 89.3499756f, -288.308533f, -168.324646f, 311.6159f, -468.341949f, 381.983948f, -1.39886475f, -102.288605f, -87.4248657f);
            float3x4 r3 = float3x4(34.552002f, -251.189758f, -19.0598755f, 64.76477f, 0.125f, 30.4605713f, 44.760437f, -437.0456f, -259.2056f, -0.5508728f, 83.49725f, 74.6676f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mod_wide_scalar()
        {
            float3x4 a0 = float3x4(-433.417f, -5.51412964f, 393.3944f, 299.41156f, -120.80603f, -502.939026f, -450.807678f, 186.094788f, -84.47363f, -318.7815f, 433.4547f, -54.60019f);
            float b0 = (-90.49924f);
            float3x4 r0 = float3x4(-71.4200439f, -5.51412964f, 31.39746f, 27.9138489f, -30.3067932f, -50.44284f, -88.81073f, 5.09631348f, -84.47363f, -47.283783f, 71.45776f, -54.60019f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x4 a1 = float3x4(-172.338867f, 222.361877f, 5.79638672f, 254.5108f, -433.0937f, -203.082611f, -75.3564148f, 252.289124f, -69.4039f, 5.337219f, -279.060425f, 483.5506f);
            float b1 = (-429.714661f);
            float3x4 r1 = float3x4(-172.338867f, 222.361877f, 5.79638672f, 254.5108f, -3.37902832f, -203.082611f, -75.3564148f, 252.289124f, -69.4039f, 5.337219f, -279.060425f, 53.8359375f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x4 a2 = float3x4(-331.993347f, 67.8396f, -124.720764f, 38.1759033f, 271.287f, 405.773621f, -194.761444f, 235.724f, 465.984863f, -304.153168f, -295.520264f, 313.7224f);
            float b2 = (336f);
            float3x4 r2 = float3x4(-331.993347f, 67.8396f, -124.720764f, 38.1759033f, 271.287f, 69.77362f, -194.761444f, 235.724f, 129.984863f, -304.153168f, -295.520264f, 313.7224f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x4 a3 = float3x4(-232.202637f, 244.096619f, 162.524231f, 390.016174f, 90.00452f, 155.933533f, 217.3377f, -306.819275f, 149.09375f, 503.828369f, -194.130127f, 214.863037f);
            float b3 = (191.619751f);
            float3x4 r3 = float3x4(-40.5828857f, 52.4768677f, 162.524231f, 6.77667236f, 90.00452f, 155.933533f, 25.7179565f, -115.199524f, 149.09375f, 120.588867f, -2.510376f, 23.2432861f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float3x4 b0 = float3x4(-159.140259f, 230.17334f, 14.7793579f, -303.1565f, 399.635f, 206.6947f, 397.0448f, -393.890656f, -372.067078f, 201.012268f, -95.566864f, -258.951477f);
            float3x4 r0 = float3x4(-78.14188f, -166.249054f, -12.1590881f, -93.2659f, -396.4224f, -189.727692f, -396.4224f, -2.53173828f, -24.3553162f, -195.410126f, -14.1549377f, -137.470917f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (106.983582f);
            float3x4 b1 = float3x4(469.323547f, -34.80899f, 184.836548f, 374.79425f, -131.872711f, -120.092865f, 4.506653f, -111.401947f, 391.54248f, -218.668884f, 196.377441f, -511.032623f);
            float3x4 r1 = float3x4(106.983582f, 2.55661f, 106.983582f, 106.983582f, 106.983582f, 106.983582f, 3.33056641f, 106.983582f, 106.983582f, 106.983582f, 106.983582f, 106.983582f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (499.9535f);
            float3x4 b2 = float3x4(-433.523071f, -163.866852f, 177.004028f, 110.650146f, 17.68457f, -95.85297f, -432.440979f, 192.692078f, -268.131775f, 271.075134f, 423.7027f, -413.233246f);
            float3x4 r2 = float3x4(66.43042f, 8.352936f, 145.945435f, 57.3529053f, 4.78552246f, 20.68866f, 67.51251f, 114.569336f, 231.821716f, 228.878357f, 76.25079f, 86.7202454f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (127.956238f);
            float3x4 b3 = float3x4(-298.204681f, -352.4181f, -175.607727f, -152.899292f, 34.6194458f, -380.802948f, 0.352050781f, 485.900879f, 266.150818f, 483.82074f, 11.777832f, 274.135864f);
            float3x4 r3 = float3x4(127.956238f, 127.956238f, 127.956238f, 127.956238f, 24.0979f, 127.956238f, 0.1618042f, 127.956238f, 127.956238f, 127.956238f, 10.1779175f, 127.956238f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_plus()
        {
            float3x4 a0 = float3x4(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f, -320.518463f, 102.054382f, -107.00351f, -428.7762f);
            float3x4 r0 = float3x4(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f, 190.324646f, -350.3086f, -320.518463f, 102.054382f, -107.00351f, -428.7762f);
            TestUtils.AreEqual(+a0, r0);

            float3x4 a1 = float3x4(377.230164f, 34.28363f, 258.330383f, 465.355957f, 309.59314f, -316.937134f, -230.052673f, 301.7851f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f);
            float3x4 r1 = float3x4(377.230164f, 34.28363f, 258.330383f, 465.355957f, 309.59314f, -316.937134f, -230.052673f, 301.7851f, 2.58575439f, 350.2464f, 60.8197632f, -472.4421f);
            TestUtils.AreEqual(+a1, r1);

            float3x4 a2 = float3x4(-364.802551f, 473.803162f, 285.80896f, -273.2638f, -206.686371f, -113.362305f, -351.754883f, -116.536224f, -496.053284f, -330.005341f, -379.674255f, -339.673218f);
            float3x4 r2 = float3x4(-364.802551f, 473.803162f, 285.80896f, -273.2638f, -206.686371f, -113.362305f, -351.754883f, -116.536224f, -496.053284f, -330.005341f, -379.674255f, -339.673218f);
            TestUtils.AreEqual(+a2, r2);

            float3x4 a3 = float3x4(-29.0835266f, 485.926636f, 183.724854f, -258.392456f, 486.4469f, 245.9909f, 231.854675f, -216.48996f, -163.009186f, 175.325439f, 404.378f, 87.64923f);
            float3x4 r3 = float3x4(-29.0835266f, 485.926636f, 183.724854f, -258.392456f, 486.4469f, 245.9909f, 231.854675f, -216.48996f, -163.009186f, 175.325439f, 404.378f, 87.64923f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_neg()
        {
            float3x4 a0 = float3x4(420.227173f, -196.2575f, -335.426819f, 509.04364f, -33.0144043f, -498.575317f, -495.837952f, -270.859467f, 19.68689f, 268.2367f, -180.600525f, 223.381287f);
            float3x4 r0 = float3x4(-420.227173f, 196.2575f, 335.426819f, -509.04364f, 33.0144043f, 498.575317f, 495.837952f, 270.859467f, -19.68689f, -268.2367f, 180.600525f, -223.381287f);
            TestUtils.AreEqual(-a0, r0);

            float3x4 a1 = float3x4(-410.392059f, -349.149475f, -110.9393f, -238.2196f, 292.543518f, 469.2926f, 48.29071f, 88.7237549f, 66.1485f, 55.7080078f, 464.541382f, 499.2428f);
            float3x4 r1 = float3x4(410.392059f, 349.149475f, 110.9393f, 238.2196f, -292.543518f, -469.2926f, -48.29071f, -88.7237549f, -66.1485f, -55.7080078f, -464.541382f, -499.2428f);
            TestUtils.AreEqual(-a1, r1);

            float3x4 a2 = float3x4(175.015015f, -306.1656f, 149.660034f, 320.391724f, -359.8338f, 22.0384521f, -159.55426f, 419.822449f, 303.323425f, 363.716736f, 280.887878f, -270.6513f);
            float3x4 r2 = float3x4(-175.015015f, 306.1656f, -149.660034f, -320.391724f, 359.8338f, -22.0384521f, 159.55426f, -419.822449f, -303.323425f, -363.716736f, -280.887878f, 270.6513f);
            TestUtils.AreEqual(-a2, r2);

            float3x4 a3 = float3x4(-201.615753f, 95.48926f, 191.070251f, 371.973572f, 296.512573f, -164.169922f, -347.4581f, -237.404968f, -228.701965f, 61.0822754f, 128.331543f, 331.2558f);
            float3x4 r3 = float3x4(201.615753f, -95.48926f, -191.070251f, -371.973572f, -296.512573f, 164.169922f, 347.4581f, 237.404968f, 228.701965f, -61.0822754f, -128.331543f, -331.2558f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_prefix_inc()
        {
            float3x4 a0 = float3x4(-99.79556f, 458.741821f, 96.1790161f, -48.55246f, -315.728973f, -299.230164f, -323.614868f, -456.8903f, -76.50766f, -305.584778f, 64.0965f, 148.679321f);
            float3x4 r0 = float3x4(-98.79556f, 459.741821f, 97.1790161f, -47.55246f, -314.728973f, -298.230164f, -322.614868f, -455.8903f, -75.50766f, -304.584778f, 65.0965f, 149.679321f);
            TestUtils.AreEqual(++a0, r0);

            float3x4 a1 = float3x4(363.2849f, -326.8778f, -179.894653f, 339.8766f, -38.41043f, -153.373688f, 261.625549f, 155.030823f, -396.650238f, 301.3058f, -221.355408f, -429.698151f);
            float3x4 r1 = float3x4(364.2849f, -325.8778f, -178.894653f, 340.8766f, -37.41043f, -152.373688f, 262.625549f, 156.030823f, -395.650238f, 302.3058f, -220.355408f, -428.698151f);
            TestUtils.AreEqual(++a1, r1);

            float3x4 a2 = float3x4(-271.2893f, -377.5592f, 223.232422f, -71.076355f, -388.2279f, 131.283142f, 22.3049316f, -480.760468f, 200.951782f, 117.9541f, 139.525818f, 335.6897f);
            float3x4 r2 = float3x4(-270.2893f, -376.5592f, 224.232422f, -70.076355f, -387.2279f, 132.283142f, 23.3049316f, -479.760468f, 201.951782f, 118.9541f, 140.525818f, 336.6897f);
            TestUtils.AreEqual(++a2, r2);

            float3x4 a3 = float3x4(162.6615f, -254.7315f, -89.25604f, 314.36554f, 244.728149f, 34.01062f, -90.44528f, -472.63623f, -34.5667725f, -71.27185f, -396.4901f, -314.987457f);
            float3x4 r3 = float3x4(163.6615f, -253.7315f, -88.25604f, 315.36554f, 245.728149f, 35.01062f, -89.44528f, -471.63623f, -33.5667725f, -70.27185f, -395.4901f, -313.987457f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_postfix_inc()
        {
            float3x4 a0 = float3x4(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f, 153.7503f, -174.173f, -427.401062f, 215.110229f);
            float3x4 r0 = float3x4(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f, 271.454651f, 55.7368774f, 153.7503f, -174.173f, -427.401062f, 215.110229f);
            TestUtils.AreEqual(a0++, r0);

            float3x4 a1 = float3x4(159.861023f, 241.4649f, 287.220459f, -170.104645f, -270.652466f, -162.86026f, 454.488831f, -449.9273f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f);
            float3x4 r1 = float3x4(159.861023f, 241.4649f, 287.220459f, -170.104645f, -270.652466f, -162.86026f, 454.488831f, -449.9273f, 209.522644f, -311.435852f, 69.7314453f, -232.299652f);
            TestUtils.AreEqual(a1++, r1);

            float3x4 a2 = float3x4(-341.498535f, 417.7298f, 25.5656738f, -463.725647f, 504.448975f, -310.144958f, -117.398468f, 403.508728f, -111.279541f, 446.607666f, -12.35257f, -232.150116f);
            float3x4 r2 = float3x4(-341.498535f, 417.7298f, 25.5656738f, -463.725647f, 504.448975f, -310.144958f, -117.398468f, 403.508728f, -111.279541f, 446.607666f, -12.35257f, -232.150116f);
            TestUtils.AreEqual(a2++, r2);

            float3x4 a3 = float3x4(64.57703f, 193.584351f, 382.050354f, -462.064117f, -122.30658f, 428.7763f, 338.97876f, 227.544067f, -169.321228f, -95.7655945f, -169.855347f, 439.3f);
            float3x4 r3 = float3x4(64.57703f, 193.584351f, 382.050354f, -462.064117f, -122.30658f, 428.7763f, 338.97876f, 227.544067f, -169.321228f, -95.7655945f, -169.855347f, 439.3f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_prefix_dec()
        {
            float3x4 a0 = float3x4(-416.201233f, -96.63788f, -50.14566f, -207.316437f, 439.479065f, -304.400818f, 337.968933f, 246.088989f, 171.964539f, -227.44281f, 298.2848f, 326.5078f);
            float3x4 r0 = float3x4(-417.201233f, -97.63788f, -51.14566f, -208.316437f, 438.479065f, -305.400818f, 336.968933f, 245.088989f, 170.964539f, -228.44281f, 297.2848f, 325.5078f);
            TestUtils.AreEqual(--a0, r0);

            float3x4 a1 = float3x4(400.7209f, -326.452972f, -24.5845032f, 112.796875f, -341.9763f, -503.27417f, -79.6352539f, -131.00415f, 147.893677f, -15.7086487f, 188.758423f, 307.791931f);
            float3x4 r1 = float3x4(399.7209f, -327.452972f, -25.5845032f, 111.796875f, -342.9763f, -504.27417f, -80.6352539f, -132.00415f, 146.893677f, -16.7086487f, 187.758423f, 306.791931f);
            TestUtils.AreEqual(--a1, r1);

            float3x4 a2 = float3x4(-406.667725f, -188.69223f, -505.2157f, -372.241943f, -4.031769f, 83.76776f, -30.6314087f, -436.906555f, -51.668396f, 345.021545f, 4.73535156f, -68.65332f);
            float3x4 r2 = float3x4(-407.667725f, -189.69223f, -506.2157f, -373.241943f, -5.031769f, 82.76776f, -31.6314087f, -437.906555f, -52.668396f, 344.021545f, 3.73535156f, -69.65332f);
            TestUtils.AreEqual(--a2, r2);

            float3x4 a3 = float3x4(481.4961f, -357.673279f, 153.329651f, -233.624329f, -35.23831f, 340.619629f, 259.928833f, 335.354919f, 85.36487f, -1.39398193f, -407.4104f, -145.793427f);
            float3x4 r3 = float3x4(480.4961f, -358.673279f, 152.329651f, -234.624329f, -36.23831f, 339.619629f, 258.928833f, 334.354919f, 84.36487f, -2.393982f, -408.4104f, -146.793427f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float3x4_operator_postfix_dec()
        {
            float3x4 a0 = float3x4(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f, -182.405731f, 450.1281f, -129.232666f, -332.154968f);
            float3x4 r0 = float3x4(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f, -281.1117f, -262.0626f, -182.405731f, 450.1281f, -129.232666f, -332.154968f);
            TestUtils.AreEqual(a0--, r0);

            float3x4 a1 = float3x4(-261.0089f, -230.227783f, -483.066528f, 378.641235f, 487.344849f, -192.177856f, -357.0542f, -396.302063f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f);
            float3x4 r1 = float3x4(-261.0089f, -230.227783f, -483.066528f, 378.641235f, 487.344849f, -192.177856f, -357.0542f, -396.302063f, 279.424255f, 115.867737f, -20.8232117f, 323.4054f);
            TestUtils.AreEqual(a1--, r1);

            float3x4 a2 = float3x4(379.156128f, 409.222473f, -428.2567f, -425.2884f, -194.6413f, -258.848358f, -208.985779f, -313.4259f, 178.3125f, 176.78949f, -370.7863f, 64.90387f);
            float3x4 r2 = float3x4(379.156128f, 409.222473f, -428.2567f, -425.2884f, -194.6413f, -258.848358f, -208.985779f, -313.4259f, 178.3125f, 176.78949f, -370.7863f, 64.90387f);
            TestUtils.AreEqual(a2--, r2);

            float3x4 a3 = float3x4(449.637756f, -203.437408f, 417.137329f, -197.347351f, 446.023376f, 239.974548f, 350.618042f, -264.747253f, 186.44165f, 353.759521f, 68.23419f, -240.610687f);
            float3x4 r3 = float3x4(449.637756f, -203.437408f, 417.137329f, -197.347351f, 446.023376f, 239.974548f, 350.618042f, -264.747253f, 186.44165f, 353.759521f, 68.23419f, -240.610687f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}