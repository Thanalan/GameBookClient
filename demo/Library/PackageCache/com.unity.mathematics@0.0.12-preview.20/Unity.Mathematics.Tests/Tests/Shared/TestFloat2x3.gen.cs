// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2x3
    {
        [TestCompiler]
        public static void float2x3_zero()
        {
            TestUtils.AreEqual(float2x3.zero.c0.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c0.y, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c1.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c1.y, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c2.x, 0.0f);
            TestUtils.AreEqual(float2x3.zero.c2.y, 0.0f);
        }

        [TestCompiler]
        public static void float2x3_operator_equal_wide_wide()
        {
            float2x3 a0 = float2x3(-135.18924f, -49.0941162f, 169.129822f, 240.8053f, 314.7392f, 442.393f);
            float2x3 b0 = float2x3(-220.014648f, 66.98004f, 499.2016f, -371.1131f, 208.448669f, 390.8037f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x3 a1 = float2x3(177.924438f, 335.5334f, 168.15448f, 350.729553f, 367.178467f, 46.9414673f);
            float2x3 b1 = float2x3(-72.44382f, 362.97644f, 194.678345f, 471.644836f, -404.044678f, -144.696747f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x3 a2 = float2x3(188.76416f, -97.2113953f, -293.320984f, -234.822937f, 417.0337f, 26.3864136f);
            float2x3 b2 = float2x3(-494.446655f, -252.970367f, 234.417114f, 398.724f, 260.4287f, 370.144226f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x3 a3 = float2x3(269.245728f, 29.4741821f, 479.485229f, -237.230957f, -221.9837f, -506.672546f);
            float2x3 b3 = float2x3(89.579834f, -434.816833f, -109.845337f, 336.973022f, -409.154968f, 500.387573f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(65.6712f, 404.415527f, -269.730164f, 83.6306152f, 152.9945f, -155.868286f);
            float b0 = (-155.815765f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x3 a1 = float2x3(314.671265f, 290.04895f, -132.6352f, -65.66748f, -69.68326f, -191.190765f);
            float b1 = (386.365173f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x3 a2 = float2x3(186.845215f, -319.144043f, -49.70108f, -300.8819f, 333.396851f, 386.3775f);
            float b2 = (-232.895691f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x3 a3 = float2x3(-296.7019f, 141.542358f, -227.323334f, 83.87286f, -410.91687f, 110.501282f);
            float b3 = (-309.1172f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float2x3 b0 = float2x3(-400.4892f, -71.2868347f, 156.978088f, -225.238739f, 499.141785f, -211.979919f);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (428.311951f);
            float2x3 b1 = float2x3(-489.501343f, -5.691559f, -30.8659363f, -362.9831f, 184.503174f, -160.470612f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (316.668823f);
            float2x3 b2 = float2x3(390.369263f, 505.1051f, -294.6487f, 443.1991f, 96.5592651f, -257.012939f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-245.054962f);
            float2x3 b3 = float2x3(326.464844f, -23.9599f, -168.694885f, 386.2486f, -227.090637f, -336.612427f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_not_equal_wide_wide()
        {
            float2x3 a0 = float2x3(279.994141f, -43.34201f, -465.724731f, 317.466553f, 85.7149658f, 360.8905f);
            float2x3 b0 = float2x3(-460.9121f, -476.009033f, 468.1364f, -341.012543f, -62.65805f, -458.801666f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x3 a1 = float2x3(366.081543f, 154.542847f, 332.4262f, 397.11322f, -431.374969f, 489.0108f);
            float2x3 b1 = float2x3(-457.730225f, -59.5232544f, 3.024231f, 155.812744f, -19.8399048f, -6.01693726f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x3 a2 = float2x3(398.4336f, -489.817932f, 171.4049f, -67.82968f, -192.278717f, 227.84082f);
            float2x3 b2 = float2x3(-406.207916f, -102.420715f, -40.362915f, 452.6754f, 93.25757f, -258.378052f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x3 a3 = float2x3(62.1381836f, 262.186462f, -404.0531f, 34.449585f, -204.795776f, -285.4118f);
            float2x3 b3 = float2x3(-184.0498f, -379.2353f, -370.687317f, -255.947235f, 29.0557861f, 322.407654f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_not_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(-155.4411f, -19.4266052f, 174.633057f, 507.920715f, 59.177063f, 171.151489f);
            float b0 = (-393.413544f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x3 a1 = float2x3(-58.92328f, 492.20105f, -165.241516f, 270.341f, -380.243256f, 501.899048f);
            float b1 = (-398.176849f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x3 a2 = float2x3(-134.345459f, 46.7709961f, 161.459961f, 261.514221f, -145.6124f, -0.449920654f);
            float b2 = (458.400452f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x3 a3 = float2x3(350.461426f, 242.664f, 382.677063f, -468.967957f, -497.459473f, -80.93225f);
            float b3 = (202.221008f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float2x3 b0 = float2x3(459.553223f, 436.453247f, -488.714172f, 392.767944f, -266.736633f, 338.557861f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-338.100128f);
            float2x3 b1 = float2x3(-152.314545f, -452.820679f, 209.439331f, 50.10797f, 372.4344f, -488.0213f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (489.740784f);
            float2x3 b2 = float2x3(270.4001f, -472.846771f, -286.850464f, -384.691864f, 443.423523f, 358.7472f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-15.4140625f);
            float2x3 b3 = float2x3(-342.179169f, 468.967529f, -130.568085f, 401.785828f, -268.352264f, -239.231018f);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_wide_wide()
        {
            float2x3 a0 = float2x3(51.7102661f, -313.85556f, 283.047668f, 235.021912f, 44.07837f, -207.255676f);
            float2x3 b0 = float2x3(-261.835236f, -19.81073f, -149.25882f, 205.99823f, -306.024384f, 102.121704f);
            bool2x3 r0 = bool2x3(false, true, false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x3 a1 = float2x3(3.38293457f, -144.301331f, -69.3696f, -135.667969f, -194.787354f, -33.473877f);
            float2x3 b1 = float2x3(231.906311f, 179.49884f, 473.2249f, 15.8916626f, 270.049927f, 490.914f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x3 a2 = float2x3(-19.67508f, 423.237976f, -71.6983f, -501.886f, 7.64386f, 302.262878f);
            float2x3 b2 = float2x3(-185.734131f, 76.4331055f, 97.75232f, 419.300781f, 73.953186f, 481.032349f);
            bool2x3 r2 = bool2x3(false, false, true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x3 a3 = float2x3(-140.5505f, -436.5867f, -351.4417f, 364.970825f, 301.8941f, 407.550964f);
            float2x3 b3 = float2x3(7.00744629f, -7.32409668f, -413.075745f, -154.1189f, 449.202881f, 502.014282f);
            bool2x3 r3 = bool2x3(true, true, false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_wide_scalar()
        {
            float2x3 a0 = float2x3(-221.869781f, -121.546478f, -97.5239258f, 479.8811f, 67.11902f, 137.3288f);
            float b0 = (199.0675f);
            bool2x3 r0 = bool2x3(true, true, true, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x3 a1 = float2x3(282.9666f, -111.413147f, -288.081116f, 82.6654053f, -361.6429f, -68.0881958f);
            float b1 = (258.2791f);
            bool2x3 r1 = bool2x3(false, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x3 a2 = float2x3(12.7880249f, -78.76297f, 25.7277222f, 101.37085f, -330.442657f, -48.9205322f);
            float b2 = (-66.703064f);
            bool2x3 r2 = bool2x3(false, true, false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x3 a3 = float2x3(359.604431f, 241.2768f, -183.437775f, 423.027161f, -334.622742f, -98.31558f);
            float b3 = (-8.150085f);
            bool2x3 r3 = bool2x3(false, false, true, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float2x3 b0 = float2x3(-377.196533f, -505.147552f, 375.9267f, 110.17395f, -118.097565f, -40.4508972f);
            bool2x3 r0 = bool2x3(false, false, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-299.744324f);
            float2x3 b1 = float2x3(31.4371338f, -458.904541f, 13.6846924f, -458.5069f, 248.276489f, 389.231445f);
            bool2x3 r1 = bool2x3(true, false, true, false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (488.745544f);
            float2x3 b2 = float2x3(-221.637878f, -424.2672f, 249.059021f, -22.1361389f, -442.247742f, -340.857544f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-95.1117249f);
            float2x3 b3 = float2x3(15.4094238f, 87.29248f, 495.067627f, 316.0185f, -125.568115f, 122.164795f);
            bool2x3 r3 = bool2x3(true, true, true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_wide_wide()
        {
            float2x3 a0 = float2x3(-229.29068f, 505.536621f, -73.80707f, 100.292053f, -419.214783f, -159.559753f);
            float2x3 b0 = float2x3(-445.845032f, -420.035278f, 299.0244f, -13.8809814f, 151.5617f, -163.50943f);
            bool2x3 r0 = bool2x3(true, true, false, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x3 a1 = float2x3(-396.770355f, 127.037415f, 489.1399f, 51.9188843f, 155.384766f, -135.631653f);
            float2x3 b1 = float2x3(-391.096039f, 479.283752f, -77.6748657f, -46.584198f, -415.377f, 71.46698f);
            bool2x3 r1 = bool2x3(false, false, true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x3 a2 = float2x3(-425.978149f, -228.430511f, 383.03833f, 136.533569f, 8.602417f, -251.324371f);
            float2x3 b2 = float2x3(-206.061035f, 360.8363f, 236.968811f, 14.550354f, 364.735168f, -159.06131f);
            bool2x3 r2 = bool2x3(false, false, true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x3 a3 = float2x3(-345.954926f, -170.565918f, -293.2544f, 139.125f, 214.3031f, 238.7699f);
            float2x3 b3 = float2x3(226.631165f, 182.796021f, 341.839355f, -79.13046f, -247.296814f, 164.589111f);
            bool2x3 r3 = bool2x3(false, false, false, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_wide_scalar()
        {
            float2x3 a0 = float2x3(11.156311f, -411.023224f, 385.885559f, -485.103058f, -491.180023f, 405.175354f);
            float b0 = (-302.816956f);
            bool2x3 r0 = bool2x3(true, false, true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x3 a1 = float2x3(173.575073f, 501.306824f, -367.027771f, -86.12451f, -489.090576f, -172.518158f);
            float b1 = (69.26929f);
            bool2x3 r1 = bool2x3(true, true, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x3 a2 = float2x3(-18.1496277f, -238.8945f, -27.2391357f, 471.779358f, 240.164551f, -481.4781f);
            float b2 = (-236.414948f);
            bool2x3 r2 = bool2x3(true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x3 a3 = float2x3(185.59436f, -510.228149f, -183.2862f, -386.127655f, -13.6382141f, -7.34790039f);
            float b3 = (33.29474f);
            bool2x3 r3 = bool2x3(true, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float2x3 b0 = float2x3(-226.2044f, -423.465f, 409.405518f, 453.877075f, 87.47571f, 113.795593f);
            bool2x3 r0 = bool2x3(true, true, true, false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (176.409241f);
            float2x3 b1 = float2x3(-140.440033f, -182.48288f, -158.2933f, -162.685333f, -193.328674f, 230.181274f);
            bool2x3 r1 = bool2x3(true, true, true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-102.58783f);
            float2x3 b2 = float2x3(392.520569f, -177.478668f, -10.2950134f, -24.04895f, 172.448669f, 374.048035f);
            bool2x3 r2 = bool2x3(false, true, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-368.99762f);
            float2x3 b3 = float2x3(-210.195282f, 149.470215f, -281.343262f, -100.469177f, 304.864441f, -361.524841f);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_equal_wide_wide()
        {
            float2x3 a0 = float2x3(240.090515f, 462.213135f, 293.08252f, -427.870667f, -405.5227f, 204.591919f);
            float2x3 b0 = float2x3(-81.20383f, 493.637451f, -411.4721f, 99.16443f, -295.6677f, -480.462555f);
            bool2x3 r0 = bool2x3(false, true, false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x3 a1 = float2x3(294.6701f, -327.564453f, -456.12326f, 282.30127f, 421.881165f, -311.71283f);
            float2x3 b1 = float2x3(74.41406f, 260.916138f, 306.173279f, 139.564819f, -505.752472f, -489.6268f);
            bool2x3 r1 = bool2x3(false, true, true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x3 a2 = float2x3(84.5675049f, 447.244629f, -154.494354f, -424.364746f, 36.68451f, 267.0703f);
            float2x3 b2 = float2x3(-280.0326f, 303.1599f, 511.1902f, -104.659729f, 95.14661f, -125.636353f);
            bool2x3 r2 = bool2x3(false, false, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x3 a3 = float2x3(307.893921f, -351.760132f, -157.360352f, 152.709045f, 372.267151f, 202.368286f);
            float2x3 b3 = float2x3(376.2398f, -415.774719f, -47.48105f, 117.722107f, 469.378357f, -263.042358f);
            bool2x3 r3 = bool2x3(true, false, true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(309.192444f, 69.67377f, -101.724182f, -315.9724f, -346.011047f, 424.15387f);
            float b0 = (292.924255f);
            bool2x3 r0 = bool2x3(false, true, true, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x3 a1 = float2x3(-410.870056f, 183.821167f, 320.4425f, -257.870056f, -386.801758f, -182.938812f);
            float b1 = (-483.902649f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x3 a2 = float2x3(349.250122f, 373.5691f, 259.1515f, 450.130066f, -128.525543f, -43.8748779f);
            float b2 = (485.311584f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x3 a3 = float2x3(457.385742f, 479.451843f, -499.516449f, -398.132935f, 402.484863f, 87.91608f);
            float b3 = (-77.6383057f);
            bool2x3 r3 = bool2x3(false, false, true, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float2x3 b0 = float2x3(51.1589966f, 340.443665f, 312.81427f, 354.1925f, 136.396729f, -94.76788f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (288.5443f);
            float2x3 b1 = float2x3(304.042847f, -148.618073f, -506.3001f, 27.5812378f, 48.47113f, 104.883484f);
            bool2x3 r1 = bool2x3(true, false, false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-488.685852f);
            float2x3 b2 = float2x3(-480.435181f, 421.936646f, 239.721069f, -101.018433f, -283.951477f, -55.24353f);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-455.80484f);
            float2x3 b3 = float2x3(131.107239f, -461.6988f, -388.482849f, -258.936035f, -225.223541f, -116.019989f);
            bool2x3 r3 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_equal_wide_wide()
        {
            float2x3 a0 = float2x3(-386.5918f, -157.120789f, 391.015259f, -511.886871f, -5.42202759f, 287.645264f);
            float2x3 b0 = float2x3(153.443f, 49.8924561f, 78.02582f, 138.813721f, -225.51059f, -339.3561f);
            bool2x3 r0 = bool2x3(false, false, true, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x3 a1 = float2x3(-122.535187f, 7.48144531f, 152.946411f, 48.9862061f, 57.3381348f, 300.4649f);
            float2x3 b1 = float2x3(-373.302063f, 364.9359f, -322.7154f, 125.47821f, -25.77658f, 297.518921f);
            bool2x3 r1 = bool2x3(true, false, true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x3 a2 = float2x3(349.25708f, 85.7496948f, -230.953308f, 418.711243f, -131.039917f, -126.512207f);
            float2x3 b2 = float2x3(73.22235f, 462.783752f, 393.191345f, -95.0014343f, 381.357056f, 93.03192f);
            bool2x3 r2 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x3 a3 = float2x3(-156.818481f, 422.3775f, -413.089325f, 219.442749f, 35.5911255f, 447.181519f);
            float2x3 b3 = float2x3(254.253235f, 90.67279f, 348.938171f, 161.337646f, 79.43561f, 420.243469f);
            bool2x3 r3 = bool2x3(false, true, false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_equal_wide_scalar()
        {
            float2x3 a0 = float2x3(495.4574f, -14.3451233f, -463.4748f, 217.517517f, -246.865723f, -377.6587f);
            float b0 = (189.205139f);
            bool2x3 r0 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x3 a1 = float2x3(53.8151245f, -221.505463f, 252.994324f, -116.440369f, -395.3633f, 164.772583f);
            float b1 = (-123.332947f);
            bool2x3 r1 = bool2x3(true, false, true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x3 a2 = float2x3(-287.007324f, 184.195557f, 273.012268f, -418.1424f, 249.3841f, 396.392151f);
            float b2 = (355.837036f);
            bool2x3 r2 = bool2x3(false, false, false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x3 a3 = float2x3(332.6654f, -335.12146f, -302.0869f, 254.442261f, 179.005066f, 71.1767f);
            float b3 = (243.761414f);
            bool2x3 r3 = bool2x3(true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float2x3 b0 = float2x3(204.802979f, -101.104034f, -122.055023f, -70.45615f, -239.62027f, -185.992737f);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-455.612579f);
            float2x3 b1 = float2x3(276.665833f, 79.39917f, 416.420532f, 379.2735f, -439.5147f, 67.14099f);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-74.56064f);
            float2x3 b2 = float2x3(-367.256348f, 494.950745f, -61.2355347f, -429.170258f, -213.824677f, -264.310181f);
            bool2x3 r2 = bool2x3(true, false, false, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (243.11377f);
            float2x3 b3 = float2x3(-22.38388f, 304.862f, -323.686157f, 67.93805f, 125.303589f, -400.47052f);
            bool2x3 r3 = bool2x3(true, false, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_add_wide_wide()
        {
            float2x3 a0 = float2x3(465.148376f, 278.9107f, -277.5299f, -65.1972046f, -473.324371f, -4.69555664f);
            float2x3 b0 = float2x3(483.9944f, -204.07666f, -365.673553f, -509.920868f, -270.6975f, 486.763977f);
            float2x3 r0 = float2x3(949.142761f, 74.8340454f, -643.2035f, -575.118042f, -744.021851f, 482.06842f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x3 a1 = float2x3(-470.536774f, -109.9501f, -178.701447f, -420.033783f, 290.711121f, -446.529633f);
            float2x3 b1 = float2x3(267.49176f, 251.642517f, 244.495117f, -78.67575f, 352.2055f, 82.7791748f);
            float2x3 r1 = float2x3(-203.045013f, 141.692413f, 65.79367f, -498.709534f, 642.9166f, -363.750458f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x3 a2 = float2x3(491.066467f, -261.1173f, -298.4069f, 502.4286f, 284.5943f, 401.128418f);
            float2x3 b2 = float2x3(462.5473f, -405.492f, -428.498322f, -41.87259f, -269.9275f, 75.20447f);
            float2x3 r2 = float2x3(953.6138f, -666.6093f, -726.9052f, 460.556f, 14.6668091f, 476.3329f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x3 a3 = float2x3(-36.26349f, -102.949158f, 503.198181f, -384.4291f, -45.22821f, -198.67395f);
            float2x3 b3 = float2x3(-141.913391f, -222.186768f, 41.3057251f, 148.339478f, -177.233124f, -176.51889f);
            float2x3 r3 = float2x3(-178.17688f, -325.135925f, 544.5039f, -236.08963f, -222.461334f, -375.192841f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_add_wide_scalar()
        {
            float2x3 a0 = float2x3(459.898315f, -447.663361f, -94.43863f, 126.429871f, -36.254364f, -349.6413f);
            float b0 = (500.997253f);
            float2x3 r0 = float2x3(960.895569f, 53.3338928f, 406.558624f, 627.4271f, 464.7429f, 151.355957f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x3 a1 = float2x3(-2.79125977f, 443.115234f, 268.092224f, 41.3210449f, -471.256073f, -2.664978f);
            float b1 = (-478.4148f);
            float2x3 r1 = float2x3(-481.206055f, -35.29956f, -210.322571f, -437.09375f, -949.6709f, -481.079773f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x3 a2 = float2x3(78.98584f, 311.725464f, 10.3458252f, -151.244446f, 355.2328f, -197.800751f);
            float b2 = (202.14801f);
            float2x3 r2 = float2x3(281.13385f, 513.8735f, 212.493835f, 50.9035645f, 557.3808f, 4.34725952f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x3 a3 = float2x3(255.955261f, -181.626556f, -2.45492554f, 300.900635f, -236.491943f, -160.5841f);
            float b3 = (244.1471f);
            float2x3 r3 = float2x3(500.102356f, 62.52054f, 241.692169f, 545.0477f, 7.65515137f, 83.56299f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float2x3 b0 = float2x3(-264.088135f, -106.009247f, -355.4473f, -447.3303f, -158.7002f, -199.4837f);
            float2x3 r0 = float2x3(-589.6009f, -431.522f, -680.9601f, -772.843f, -484.212952f, -524.99646f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (180.318115f);
            float2x3 b1 = float2x3(337.579346f, -37.0550232f, 230.805f, -140.174347f, 18.02417f, -138.614349f);
            float2x3 r1 = float2x3(517.897461f, 143.263092f, 411.1231f, 40.14377f, 198.342285f, 41.7037659f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (26.9041748f);
            float2x3 b2 = float2x3(-374.5376f, 154.46759f, 268.38385f, -190.963013f, 188.617249f, -504.916138f);
            float2x3 r2 = float2x3(-347.633423f, 181.371765f, 295.288025f, -164.058838f, 215.521423f, -478.011963f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (20.45404f);
            float2x3 b3 = float2x3(197.945374f, 251.411926f, -421.0904f, 111.445374f, -73.26889f, 480.884583f);
            float2x3 r3 = float2x3(218.399414f, 271.865967f, -400.636353f, 131.899414f, -52.81485f, 501.338623f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_sub_wide_wide()
        {
            float2x3 a0 = float2x3(133.371033f, -131.832123f, -197.293152f, -485.28656f, -337.550323f, 471.6671f);
            float2x3 b0 = float2x3(123.460266f, 359.56012f, -48.2484741f, 478.979065f, 207.158325f, 142.36731f);
            float2x3 r0 = float2x3(9.910767f, -491.392242f, -149.044678f, -964.2656f, -544.7086f, 329.2998f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x3 a1 = float2x3(146.506592f, -130.585052f, 110.7771f, -235.5416f, 78.87933f, -347.686157f);
            float2x3 b1 = float2x3(-125.6055f, -65.29901f, -477.876434f, 164.5f, 428.009583f, 72.62781f);
            float2x3 r1 = float2x3(272.1121f, -65.28604f, 588.653564f, -400.0416f, -349.130249f, -420.313965f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x3 a2 = float2x3(-470.820557f, -11.45929f, -167.9479f, 330.676758f, -508.350861f, -252.031891f);
            float2x3 b2 = float2x3(-446.8805f, 432.091431f, -225.554657f, -112.451965f, -210.6128f, -172.925049f);
            float2x3 r2 = float2x3(-23.9400635f, -443.55072f, 57.60675f, 443.128723f, -297.738068f, -79.10684f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x3 a3 = float2x3(-427.9342f, 192.6576f, 168.429321f, 457.308777f, 470.058533f, -299.711884f);
            float2x3 b3 = float2x3(-80.60748f, 270.046082f, -154.255585f, 148.475769f, 13.6611328f, 70.67108f);
            float2x3 r3 = float2x3(-347.326721f, -77.38849f, 322.6849f, 308.833f, 456.3974f, -370.382965f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_sub_wide_scalar()
        {
            float2x3 a0 = float2x3(48.9367065f, 410.4516f, -364.4417f, 163.980591f, -460.067322f, 110.919434f);
            float b0 = (-291.5904f);
            float2x3 r0 = float2x3(340.5271f, 702.042f, -72.85132f, 455.570984f, -168.476929f, 402.509827f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x3 a1 = float2x3(204.358337f, -377.9257f, -470.262054f, 400.5349f, 461.507568f, -246.287262f);
            float b1 = (180.269714f);
            float2x3 r1 = float2x3(24.088623f, -558.195435f, -650.531738f, 220.2652f, 281.237854f, -426.556976f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x3 a2 = float2x3(21.6052856f, -121.427368f, -122.718414f, -122.938721f, 360.15094f, 342.874573f);
            float b2 = (246.350708f);
            float2x3 r2 = float2x3(-224.745422f, -367.778076f, -369.069122f, -369.289429f, 113.800232f, 96.5238647f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x3 a3 = float2x3(18.92981f, 97.0437f, 485.914978f, -205.75766f, 253.443237f, -121.163055f);
            float b3 = (164.602356f);
            float2x3 r3 = float2x3(-145.672546f, -67.5586548f, 321.312622f, -370.360016f, 88.84088f, -285.7654f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float2x3 b0 = float2x3(452.352539f, 256.9898f, -275.159882f, -89.02753f, 488.2284f, -333.2173f);
            float2x3 r0 = float2x3(-157.766052f, 37.59668f, 569.746338f, 383.614f, -193.6419f, 627.8038f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-64.233f);
            float2x3 b1 = float2x3(-66.04172f, 341.204956f, -385.775055f, 75.3947754f, 354.943726f, 169.131409f);
            float2x3 r1 = float2x3(1.80871582f, -405.437958f, 321.542053f, -139.627777f, -419.176727f, -233.36441f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (88.21661f);
            float2x3 b2 = float2x3(1.73498535f, 122.538025f, -264.945f, -50.83719f, -347.65033f, 4.06555176f);
            float2x3 r2 = float2x3(86.48163f, -34.32141f, 353.161621f, 139.0538f, 435.866943f, 84.15106f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-79.09543f);
            float2x3 b3 = float2x3(354.358337f, -292.4925f, -53.2089844f, -246.3476f, 299.203369f, 432.1847f);
            float2x3 r3 = float2x3(-433.453766f, 213.397064f, -25.8864441f, 167.252167f, -378.2988f, -511.280121f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mul_wide_wide()
        {
            float2x3 a0 = float2x3(-394.780548f, -412.3722f, -25.8745728f, -241.045959f, -93.6759949f, 244.159973f);
            float2x3 b0 = float2x3(-149.763977f, -345.04538f, -284.334045f, 267.979248f, -326.6485f, -150.689667f);
            float2x3 r0 = float2x3(59123.9063f, 142287.125f, 7357.022f, -64595.3164f, 30599.123f, -36792.3867f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x3 a1 = float2x3(494.688477f, 53.5379639f, -239.4964f, 236.675842f, -211.8562f, -216.654816f);
            float2x3 b1 = float2x3(207.732422f, 366.192871f, 358.880737f, 214.853577f, 253.422791f, -307.7138f);
            float2x3 r1 = float2x3(102762.836f, 19605.22f, -85950.64f, 50850.6523f, -53689.19f, 66667.68f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x3 a2 = float2x3(467.9583f, -178.021912f, -386.394257f, -422.4354f, 464.589539f, -251.315674f);
            float2x3 b2 = float2x3(184.47113f, 426.436462f, -144.281433f, 459.4796f, -358.313354f, -201.3652f);
            float2x3 r2 = float2x3(86324.8f, -75915.03f, 55749.5156f, -194100.453f, -166468.641f, 50606.23f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x3 a3 = float2x3(-104.97879f, -66.93417f, -39.829895f, 401.5656f, 434.146179f, -336.4542f);
            float2x3 b3 = float2x3(254.909973f, 168.520935f, 8.794556f, -194.846466f, -405.362671f, -180.732178f);
            float2x3 r3 = float2x3(-26760.14f, -11279.81f, -350.286224f, -78243.64f, -175986.656f, 60808.0977f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mul_wide_scalar()
        {
            float2x3 a0 = float2x3(328.203f, -290.10672f, 236.995728f, 120.481384f, 357.903137f, 134.867249f);
            float b0 = (192.211182f);
            float2x3 r0 = float2x3(63084.2852f, -55761.7539f, 45553.23f, 23157.87f, 68792.9844f, 25922.9941f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x3 a1 = float2x3(-477.3105f, -46.729187f, -238.405f, 422.08252f, -48.83484f, 355.30835f);
            float b1 = (-438.272919f);
            float2x3 r1 = float2x3(209192.266f, 20480.1367f, 104486.453f, -184987.344f, 21402.9883f, -155722.031f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x3 a2 = float2x3(119.356628f, 98.23602f, -325.552155f, 53.9373169f, -87.45099f, -130.474121f);
            float b2 = (-196.995819f);
            float2x3 r2 = float2x3(-23512.7559f, -19352.0859f, 64132.4141f, -10625.4258f, 17227.4785f, 25702.8555f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x3 a3 = float2x3(-222.594574f, 293.361084f, 174.381958f, -327.120056f, 56.62915f, 257.541565f);
            float b3 = (126.015015f);
            float2x3 r3 = float2x3(-28050.2578f, 36967.9023f, 21974.7441f, -41222.04f, 7136.123f, 32454.1035f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float2x3 b0 = float2x3(329.360962f, -198.683441f, 184.0794f, 256.016174f, 266.226318f, -97.8947449f);
            float2x3 r0 = float2x3(-152999.6f, 92295.35f, -85511.27f, -118928.4f, -123671.359f, 45475.5039f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (159.748108f);
            float2x3 b1 = float2x3(-351.8222f, 491.801575f, 49.90204f, 424.4626f, 160.1181f, -395.9921f);
            float2x3 r1 = float2x3(-56202.93f, 78564.37f, 7971.75635f, 67807.09f, 25578.5645f, -63258.99f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (125.20166f);
            float2x3 b2 = float2x3(-265.0158f, 314.656128f, -292.712036f, -37.72989f, 165.362244f, 356.517761f);
            float2x3 r2 = float2x3(-33180.418f, 39395.47f, -36648.03f, -4723.84473f, 20703.627f, 44636.6172f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-188.813324f);
            float2x3 b3 = float2x3(504.9157f, 40.5721436f, -206.775116f, -61.60269f, 118.971619f, 53.7483521f);
            float2x3 r3 = float2x3(-95334.81f, -7660.56152f, 39041.9f, 11631.4092f, -22463.4277f, -10148.4053f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_div_wide_wide()
        {
            float2x3 a0 = float2x3(246.265747f, -269.85614f, -451.619537f, -7.388489f, -308.205566f, -373.3948f);
            float2x3 b0 = float2x3(172.119812f, -77.14111f, -325.8354f, -450.608673f, -261.262146f, -122.449493f);
            float2x3 r0 = float2x3(1.43078089f, 3.49821424f, 1.38603592f, 0.0163966864f, 1.17967939f, 3.04937816f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x3 a1 = float2x3(360.41864f, 25.8097534f, -274.050476f, 127.538574f, -447.671753f, -137.458588f);
            float2x3 b1 = float2x3(-93.2107849f, -442.005219f, 484.362732f, -390.7818f, 402.02533f, 316.6507f);
            float2x3 r1 = float2x3(-3.86670542f, -0.0583924167f, -0.565795958f, -0.326367736f, -1.11354113f, -0.434101641f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x3 a2 = float2x3(-136.133179f, 12.4376221f, 228.513f, 356.972351f, -24.7620544f, 411.6684f);
            float2x3 b2 = float2x3(397.154419f, -303.2622f, -118.591248f, -81.6503f, -84.34686f, -488.419434f);
            float2x3 r2 = float2x3(-0.3427714f, -0.0410127677f, -1.926896f, -4.37196636f, 0.2935741f, -0.8428584f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x3 a3 = float2x3(-204.078888f, 11.3654175f, 82.15228f, 37.3894653f, 394.2658f, -429.912781f);
            float2x3 b3 = float2x3(404.160522f, -136.728851f, -19.8327026f, -102.607239f, 166.116028f, -112.840179f);
            float2x3 r3 = float2x3(-0.504945159f, -0.0831237659f, -4.14226341f, -0.364394039f, 2.37343621f, 3.80992651f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_div_wide_scalar()
        {
            float2x3 a0 = float2x3(-244.517456f, 69.1123047f, -333.023132f, 257.396851f, 403.2456f, 154.34436f);
            float b0 = (-60.0243835f);
            float2x3 r0 = float2x3(4.07363558f, -1.15140378f, 5.548131f, -4.28820467f, -6.71803f, -2.571361f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x3 a1 = float2x3(131.526611f, -348.9238f, -275.5387f, 210.557922f, 287.6424f, 504.372253f);
            float b1 = (-261.8864f);
            float2x3 r1 = float2x3(-0.5022277f, 1.33234787f, 1.05213058f, -0.8040047f, -1.0983479f, -1.92591989f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x3 a2 = float2x3(491.7871f, -253.236664f, 272.895142f, 178.096191f, -460.87558f, -502.646027f);
            float b2 = (-26.6315918f);
            float2x3 r2 = float2x3(-18.4663048f, 9.508882f, -10.2470455f, -6.687403f, 17.3055973f, 18.874052f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x3 a3 = float2x3(-84.3248f, 83.7963257f, 197.042053f, 317.168274f, 403.387146f, 81.6464844f);
            float b3 = (-174.690338f);
            float2x3 r3 = float2x3(0.482710153f, -0.479684949f, -1.12795055f, -1.8156029f, -2.30915546f, -0.467378378f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float2x3 b0 = float2x3(-422.676147f, 248.129639f, 449.391357f, 245.858154f, -326.6206f, 163.715088f);
            float2x3 r0 = float2x3(-0.09874622f, 0.168209136f, 0.0928759947f, 0.169763222f, -0.1277864f, 0.2549409f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (333.6645f);
            float2x3 b1 = float2x3(38.2910767f, -472.979767f, 192.230164f, -200.296875f, -490.181519f, -211.10257f);
            float2x3 r1 = float2x3(8.713897f, -0.7054519f, 1.73575509f, -1.66584969f, -0.6806958f, -1.58058f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-322.852356f);
            float2x3 b2 = float2x3(-137.985291f, 84.32971f, 355.063477f, 276.427246f, -382.988037f, -488.647156f);
            float2x3 r2 = float2x3(2.339759f, -3.8284533f, -0.909280658f, -1.16794693f, 0.8429829f, 0.6607065f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (344.846f);
            float2x3 b3 = float2x3(168.85498f, -44.1955872f, 420.55072f, -175.6152f, -9.220581f, -344.194275f);
            float2x3 r3 = float2x3(2.04226136f, -7.802725f, 0.8199867f, -1.96364558f, -37.3995972f, -1.00189352f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mod_wide_wide()
        {
            float2x3 a0 = float2x3(-442.309875f, 368.5005f, -1.09390259f, -364.673828f, -197.343933f, -34.0349121f);
            float2x3 b0 = float2x3(-43.2450562f, -144.195862f, -62.6404724f, -336.828247f, -154.61026f, -154.029358f);
            float2x3 r0 = float2x3(-9.859314f, 80.1087646f, -1.09390259f, -27.8455811f, -42.7336731f, -34.0349121f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x3 a1 = float2x3(-101.348572f, 208.318542f, -140.770325f, 183.44696f, -463.368378f, 83.83911f);
            float2x3 b1 = float2x3(487.0462f, -469.8291f, -145.203766f, -203.384f, -22.52008f, 224.69f);
            float2x3 r1 = float2x3(-101.348572f, 208.318542f, -140.770325f, 183.44696f, -12.9667664f, 83.83911f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x3 a2 = float2x3(-64.71405f, 295.066833f, 212.25708f, 349.6283f, 119.875916f, -37.8058167f);
            float2x3 b2 = float2x3(-435.62674f, 12.0955811f, 40.3787842f, 345.784851f, -433.471252f, -355.649963f);
            float2x3 r2 = float2x3(-64.71405f, 4.772888f, 10.3631592f, 3.84344482f, 119.875916f, -37.8058167f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x3 a3 = float2x3(142.41156f, 332.244263f, -464.194275f, -296.147827f, 225.175354f, -212.060272f);
            float2x3 b3 = float2x3(4.015442f, 66.65979f, -221.853638f, -355.056763f, 357.935974f, 71.3753052f);
            float2x3 r3 = float2x3(1.87109375f, 65.6051f, -20.487f, -296.147827f, 225.175354f, -69.30966f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mod_wide_scalar()
        {
            float2x3 a0 = float2x3(-433.417f, -5.51412964f, 393.3944f, 299.41156f, -120.80603f, -502.939026f);
            float b0 = (-90.49924f);
            float2x3 r0 = float2x3(-71.4200439f, -5.51412964f, 31.39746f, 27.9138489f, -30.3067932f, -50.44284f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x3 a1 = float2x3(-450.807678f, -84.47363f, -318.7815f, 433.4547f, -54.60019f, -172.338867f);
            float b1 = (186.094788f);
            float2x3 r1 = float2x3(-78.6181f, -84.47363f, -132.6867f, 61.2651367f, -54.60019f, -172.338867f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x3 a2 = float2x3(-429.714661f, 5.79638672f, 254.5108f, -433.0937f, -203.082611f, -75.3564148f);
            float b2 = (222.361877f);
            float2x3 r2 = float2x3(-207.352783f, 5.79638672f, 32.1489258f, -210.731812f, -203.082611f, -75.3564148f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x3 a3 = float2x3(252.289124f, 5.337219f, -279.060425f, 483.5506f, -331.993347f, 336f);
            float b3 = (-69.4039f);
            float2x3 r3 = float2x3(44.0774231f, 5.337219f, -1.44482422f, 67.1272f, -54.3777466f, 58.3844f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float2x3 b0 = float2x3(-159.140259f, 230.17334f, 14.7793579f, -303.1565f, 399.635f, 206.6947f);
            float2x3 r0 = float2x3(-78.14188f, -166.249054f, -12.1590881f, -93.2659f, -396.4224f, -189.727692f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (397.0448f);
            float2x3 b1 = float2x3(-393.890656f, -372.067078f, 201.012268f, -95.566864f, -258.951477f, 106.983582f);
            float2x3 r1 = float2x3(3.15414429f, 24.9777222f, 196.032532f, 14.7773438f, 138.093323f, 76.0940552f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (469.323547f);
            float2x3 b2 = float2x3(-34.80899f, 184.836548f, 374.79425f, -131.872711f, -120.092865f, 4.506653f);
            float2x3 r2 = float2x3(16.8066711f, 99.65045f, 94.5293f, 73.7054138f, 109.044952f, 0.631652832f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-111.401947f);
            float2x3 b3 = float2x3(391.54248f, -218.668884f, 196.377441f, -511.032623f, 499.9535f, -433.523071f);
            float2x3 r3 = float2x3(-111.401947f, -111.401947f, -111.401947f, -111.401947f, -111.401947f, -111.401947f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_plus()
        {
            float2x3 a0 = float2x3(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f);
            float2x3 r0 = float2x3(271.670837f, -79.08023f, -330.985046f, 31.824707f, 315.449524f, 319.222168f);
            TestUtils.AreEqual(+a0, r0);

            float2x3 a1 = float2x3(190.324646f, -320.518463f, 102.054382f, -107.00351f, -428.7762f, 377.230164f);
            float2x3 r1 = float2x3(190.324646f, -320.518463f, 102.054382f, -107.00351f, -428.7762f, 377.230164f);
            TestUtils.AreEqual(+a1, r1);

            float2x3 a2 = float2x3(234.773926f, 258.330383f, 465.355957f, 309.59314f, -316.937134f, -230.052673f);
            float2x3 r2 = float2x3(234.773926f, 258.330383f, 465.355957f, 309.59314f, -316.937134f, -230.052673f);
            TestUtils.AreEqual(+a2, r2);

            float2x3 a3 = float2x3(301.7851f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f, 239.152344f);
            float2x3 r3 = float2x3(301.7851f, 350.2464f, 60.8197632f, -472.4421f, -364.802551f, 239.152344f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_neg()
        {
            float2x3 a0 = float2x3(420.227173f, -196.2575f, -335.426819f, 509.04364f, -33.0144043f, -498.575317f);
            float2x3 r0 = float2x3(-420.227173f, 196.2575f, 335.426819f, -509.04364f, 33.0144043f, 498.575317f);
            TestUtils.AreEqual(-a0, r0);

            float2x3 a1 = float2x3(-495.837952f, 19.68689f, 268.2367f, -180.600525f, 223.381287f, -410.392059f);
            float2x3 r1 = float2x3(495.837952f, -19.68689f, -268.2367f, 180.600525f, -223.381287f, 410.392059f);
            TestUtils.AreEqual(-a1, r1);

            float2x3 a2 = float2x3(-395.681549f, -110.9393f, -238.2196f, 292.543518f, 469.2926f, 48.29071f);
            float2x3 r2 = float2x3(395.681549f, 110.9393f, 238.2196f, -292.543518f, -469.2926f, -48.29071f);
            TestUtils.AreEqual(-a2, r2);

            float2x3 a3 = float2x3(88.7237549f, 55.7080078f, 464.541382f, 499.2428f, 175.015015f, 196.387573f);
            float2x3 r3 = float2x3(-88.7237549f, -55.7080078f, -464.541382f, -499.2428f, -175.015015f, -196.387573f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_prefix_inc()
        {
            float2x3 a0 = float2x3(-99.79556f, 458.741821f, 96.1790161f, -48.55246f, -315.728973f, -299.230164f);
            float2x3 r0 = float2x3(-98.79556f, 459.741821f, 97.1790161f, -47.55246f, -314.728973f, -298.230164f);
            TestUtils.AreEqual(++a0, r0);

            float2x3 a1 = float2x3(-323.614868f, -76.50766f, -305.584778f, 64.0965f, 148.679321f, 363.2849f);
            float2x3 r1 = float2x3(-322.614868f, -75.50766f, -304.584778f, 65.0965f, 149.679321f, 364.2849f);
            TestUtils.AreEqual(++a1, r1);

            float2x3 a2 = float2x3(-115.559235f, -179.894653f, 339.8766f, -38.41043f, -153.373688f, 261.625549f);
            float2x3 r2 = float2x3(-114.559235f, -178.894653f, 340.8766f, -37.41043f, -152.373688f, 262.625549f);
            TestUtils.AreEqual(++a2, r2);

            float2x3 a3 = float2x3(155.030823f, 301.3058f, -221.355408f, -429.698151f, -271.2893f, -264.380066f);
            float2x3 r3 = float2x3(156.030823f, 302.3058f, -220.355408f, -428.698151f, -270.2893f, -263.380066f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_postfix_inc()
        {
            float2x3 a0 = float2x3(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f);
            float2x3 r0 = float2x3(322.943542f, 472.0525f, 203.48761f, -49.8545837f, -31.4205322f, 455.3366f);
            TestUtils.AreEqual(a0++, r0);

            float2x3 a1 = float2x3(271.454651f, 153.7503f, -174.173f, -427.401062f, 215.110229f, 159.861023f);
            float2x3 r1 = float2x3(271.454651f, 153.7503f, -174.173f, -427.401062f, 215.110229f, 159.861023f);
            TestUtils.AreEqual(a1++, r1);

            float2x3 a2 = float2x3(-333.050446f, 287.220459f, -170.104645f, -270.652466f, -162.86026f, 454.488831f);
            float2x3 r2 = float2x3(-333.050446f, 287.220459f, -170.104645f, -270.652466f, -162.86026f, 454.488831f);
            TestUtils.AreEqual(a2++, r2);

            float2x3 a3 = float2x3(-449.9273f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f, 188.006592f);
            float2x3 r3 = float2x3(-449.9273f, -311.435852f, 69.7314453f, -232.299652f, -341.498535f, 188.006592f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_prefix_dec()
        {
            float2x3 a0 = float2x3(-416.201233f, -96.63788f, -50.14566f, -207.316437f, 439.479065f, -304.400818f);
            float2x3 r0 = float2x3(-417.201233f, -97.63788f, -51.14566f, -208.316437f, 438.479065f, -305.400818f);
            TestUtils.AreEqual(--a0, r0);

            float2x3 a1 = float2x3(337.968933f, 171.964539f, -227.44281f, 298.2848f, 326.5078f, 400.7209f);
            float2x3 r1 = float2x3(336.968933f, 170.964539f, -228.44281f, 297.2848f, 325.5078f, 399.7209f);
            TestUtils.AreEqual(--a1, r1);

            float2x3 a2 = float2x3(-478.031372f, -24.5845032f, 112.796875f, -341.9763f, -503.27417f, -79.6352539f);
            float2x3 r2 = float2x3(-479.031372f, -25.5845032f, 111.796875f, -342.9763f, -504.27417f, -80.6352539f);
            TestUtils.AreEqual(--a2, r2);

            float2x3 a3 = float2x3(-131.00415f, -15.7086487f, 188.758423f, 307.791931f, -406.667725f, 181.4751f);
            float2x3 r3 = float2x3(-132.00415f, -16.7086487f, 187.758423f, 306.791931f, -407.667725f, 180.4751f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float2x3_operator_postfix_dec()
        {
            float2x3 a0 = float2x3(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f);
            float2x3 r0 = float2x3(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f, 409.557556f, 47.85663f);
            TestUtils.AreEqual(a0--, r0);

            float2x3 a1 = float2x3(-281.1117f, -182.405731f, 450.1281f, -129.232666f, -332.154968f, -261.0089f);
            float2x3 r1 = float2x3(-281.1117f, -182.405731f, 450.1281f, -129.232666f, -332.154968f, -261.0089f);
            TestUtils.AreEqual(a1--, r1);

            float2x3 a2 = float2x3(205.461121f, -483.066528f, 378.641235f, 487.344849f, -192.177856f, -357.0542f);
            float2x3 r2 = float2x3(205.461121f, -483.066528f, 378.641235f, 487.344849f, -192.177856f, -357.0542f);
            TestUtils.AreEqual(a2--, r2);

            float2x3 a3 = float2x3(-396.302063f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f, 311.299f);
            float2x3 r3 = float2x3(-396.302063f, 115.867737f, -20.8232117f, 323.4054f, 379.156128f, 311.299f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}