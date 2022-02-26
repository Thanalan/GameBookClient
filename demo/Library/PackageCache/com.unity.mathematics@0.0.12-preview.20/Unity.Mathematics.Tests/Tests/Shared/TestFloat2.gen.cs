// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2
    {
        [TestCompiler]
        public static void float2_zero()
        {
            TestUtils.AreEqual(float2.zero.x, 0.0f);
            TestUtils.AreEqual(float2.zero.y, 0.0f);
        }

        [TestCompiler]
        public static void float2_constructor()
        {
            float2 a = new float2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void float2_scalar_constructor()
        {
            float2 a = new float2(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
        }

        [TestCompiler]
        public static void float2_static_constructor()
        {
            float2 a = float2(1, 2);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
        }

        [TestCompiler]
        public static void float2_static_scalar_constructor()
        {
            float2 a = float2(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
        }

        [TestCompiler]
        public static void float2_operator_equal_wide_wide()
        {
            float2 a0 = float2(-135.18924f, -49.0941162f);
            float2 b0 = float2(-220.014648f, 66.98004f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2 a1 = float2(169.129822f, 240.8053f);
            float2 b1 = float2(499.2016f, -371.1131f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2 a2 = float2(314.7392f, 442.393f);
            float2 b2 = float2(208.448669f, 390.8037f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2 a3 = float2(177.924438f, 335.5334f);
            float2 b3 = float2(-72.44382f, 362.97644f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_equal_wide_scalar()
        {
            float2 a0 = float2(65.6712f, 404.415527f);
            float b0 = (-155.815765f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2 a1 = float2(-269.730164f, 152.9945f);
            float b1 = (83.6306152f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2 a2 = float2(-155.868286f, 386.365173f);
            float b2 = (314.671265f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2 a3 = float2(290.04895f, -65.66748f);
            float b3 = (-132.6352f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float2 b0 = float2(-400.4892f, -71.2868347f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (156.978088f);
            float2 b1 = float2(-225.238739f, 499.141785f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-211.979919f);
            float2 b2 = float2(428.311951f, -489.501343f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-5.691559f);
            float2 b3 = float2(-30.8659363f, -362.9831f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_not_equal_wide_wide()
        {
            float2 a0 = float2(279.994141f, -43.34201f);
            float2 b0 = float2(-460.9121f, -476.009033f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2 a1 = float2(-465.724731f, 317.466553f);
            float2 b1 = float2(468.1364f, -341.012543f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2 a2 = float2(85.7149658f, 360.8905f);
            float2 b2 = float2(-62.65805f, -458.801666f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2 a3 = float2(366.081543f, 154.542847f);
            float2 b3 = float2(-457.730225f, -59.5232544f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_not_equal_wide_scalar()
        {
            float2 a0 = float2(-155.4411f, -19.4266052f);
            float b0 = (-393.413544f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2 a1 = float2(174.633057f, 59.177063f);
            float b1 = (507.920715f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2 a2 = float2(171.151489f, -398.176849f);
            float b2 = (-58.92328f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2 a3 = float2(492.20105f, 270.341f);
            float b3 = (-165.241516f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float2 b0 = float2(459.553223f, 436.453247f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-488.714172f);
            float2 b1 = float2(392.767944f, -266.736633f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (338.557861f);
            float2 b2 = float2(-338.100128f, -152.314545f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-452.820679f);
            float2 b3 = float2(209.439331f, 50.10797f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_wide_wide()
        {
            float2 a0 = float2(51.7102661f, -313.85556f);
            float2 b0 = float2(-261.835236f, -19.81073f);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2 a1 = float2(283.047668f, 235.021912f);
            float2 b1 = float2(-149.25882f, 205.99823f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float2 a2 = float2(44.07837f, -207.255676f);
            float2 b2 = float2(-306.024384f, 102.121704f);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2 a3 = float2(3.38293457f, -144.301331f);
            float2 b3 = float2(231.906311f, 179.49884f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_wide_scalar()
        {
            float2 a0 = float2(-221.869781f, -121.546478f);
            float b0 = (199.0675f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2 a1 = float2(-97.5239258f, 67.11902f);
            float b1 = (479.8811f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2 a2 = float2(137.3288f, 258.2791f);
            float b2 = (282.9666f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2 a3 = float2(-111.413147f, 82.6654053f);
            float b3 = (-288.081116f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float2 b0 = float2(-377.196533f, -505.147552f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (375.9267f);
            float2 b1 = float2(110.17395f, -118.097565f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-40.4508972f);
            float2 b2 = float2(-299.744324f, 31.4371338f);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-458.904541f);
            float2 b3 = float2(13.6846924f, -458.5069f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_wide_wide()
        {
            float2 a0 = float2(-229.29068f, 505.536621f);
            float2 b0 = float2(-445.845032f, -420.035278f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2 a1 = float2(-73.80707f, 100.292053f);
            float2 b1 = float2(299.0244f, -13.8809814f);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2 a2 = float2(-419.214783f, -159.559753f);
            float2 b2 = float2(151.5617f, -163.50943f);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2 a3 = float2(-396.770355f, 127.037415f);
            float2 b3 = float2(-391.096039f, 479.283752f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_wide_scalar()
        {
            float2 a0 = float2(11.156311f, -411.023224f);
            float b0 = (-302.816956f);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2 a1 = float2(385.885559f, -491.180023f);
            float b1 = (-485.103058f);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2 a2 = float2(405.175354f, 69.26929f);
            float b2 = (173.575073f);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2 a3 = float2(501.306824f, -86.12451f);
            float b3 = (-367.027771f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float2 b0 = float2(-226.2044f, -423.465f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (409.405518f);
            float2 b1 = float2(453.877075f, 87.47571f);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (113.795593f);
            float2 b2 = float2(176.409241f, -140.440033f);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-182.48288f);
            float2 b3 = float2(-158.2933f, -162.685333f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_equal_wide_wide()
        {
            float2 a0 = float2(240.090515f, 462.213135f);
            float2 b0 = float2(-81.20383f, 493.637451f);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2 a1 = float2(293.08252f, -427.870667f);
            float2 b1 = float2(-411.4721f, 99.16443f);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2 a2 = float2(-405.5227f, 204.591919f);
            float2 b2 = float2(-295.6677f, -480.462555f);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2 a3 = float2(294.6701f, -327.564453f);
            float2 b3 = float2(74.41406f, 260.916138f);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_equal_wide_scalar()
        {
            float2 a0 = float2(309.192444f, 69.67377f);
            float b0 = (292.924255f);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2 a1 = float2(-101.724182f, -346.011047f);
            float b1 = (-315.9724f);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2 a2 = float2(424.15387f, -483.902649f);
            float b2 = (-410.870056f);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2 a3 = float2(183.821167f, -257.870056f);
            float b3 = (320.4425f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float2 b0 = float2(51.1589966f, 340.443665f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (312.81427f);
            float2 b1 = float2(354.1925f, 136.396729f);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-94.76788f);
            float2 b2 = float2(288.5443f, 304.042847f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-148.618073f);
            float2 b3 = float2(-506.3001f, 27.5812378f);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_equal_wide_wide()
        {
            float2 a0 = float2(-386.5918f, -157.120789f);
            float2 b0 = float2(153.443f, 49.8924561f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2 a1 = float2(391.015259f, -511.886871f);
            float2 b1 = float2(78.02582f, 138.813721f);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2 a2 = float2(-5.42202759f, 287.645264f);
            float2 b2 = float2(-225.51059f, -339.3561f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2 a3 = float2(-122.535187f, 7.48144531f);
            float2 b3 = float2(-373.302063f, 364.9359f);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_equal_wide_scalar()
        {
            float2 a0 = float2(495.4574f, -14.3451233f);
            float b0 = (189.205139f);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2 a1 = float2(-463.4748f, -246.865723f);
            float b1 = (217.517517f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2 a2 = float2(-377.6587f, -123.332947f);
            float b2 = (53.8151245f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2 a3 = float2(-221.505463f, -116.440369f);
            float b3 = (252.994324f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float2 b0 = float2(204.802979f, -101.104034f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-122.055023f);
            float2 b1 = float2(-70.45615f, -239.62027f);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-185.992737f);
            float2 b2 = float2(-455.612579f, 276.665833f);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (79.39917f);
            float2 b3 = float2(416.420532f, 379.2735f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_add_wide_wide()
        {
            float2 a0 = float2(465.148376f, 278.9107f);
            float2 b0 = float2(483.9944f, -204.07666f);
            float2 r0 = float2(949.142761f, 74.8340454f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2 a1 = float2(-277.5299f, -65.1972046f);
            float2 b1 = float2(-365.673553f, -509.920868f);
            float2 r1 = float2(-643.2035f, -575.118042f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2 a2 = float2(-473.324371f, -4.69555664f);
            float2 b2 = float2(-270.6975f, 486.763977f);
            float2 r2 = float2(-744.021851f, 482.06842f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2 a3 = float2(-470.536774f, -109.9501f);
            float2 b3 = float2(267.49176f, 251.642517f);
            float2 r3 = float2(-203.045013f, 141.692413f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_add_wide_scalar()
        {
            float2 a0 = float2(459.898315f, -447.663361f);
            float b0 = (500.997253f);
            float2 r0 = float2(960.895569f, 53.3338928f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2 a1 = float2(-94.43863f, -36.254364f);
            float b1 = (126.429871f);
            float2 r1 = float2(31.9912415f, 90.17551f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2 a2 = float2(-349.6413f, -478.4148f);
            float b2 = (-2.79125977f);
            float2 r2 = float2(-352.432556f, -481.206055f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2 a3 = float2(443.115234f, 41.3210449f);
            float b3 = (268.092224f);
            float2 r3 = float2(711.207458f, 309.413269f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float2 b0 = float2(-264.088135f, -106.009247f);
            float2 r0 = float2(-589.6009f, -431.522f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-355.4473f);
            float2 b1 = float2(-447.3303f, -158.7002f);
            float2 r1 = float2(-802.7776f, -514.147461f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-199.4837f);
            float2 b2 = float2(180.318115f, 337.579346f);
            float2 r2 = float2(-19.1655884f, 138.095642f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-37.0550232f);
            float2 b3 = float2(230.805f, -140.174347f);
            float2 r3 = float2(193.749969f, -177.22937f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_sub_wide_wide()
        {
            float2 a0 = float2(133.371033f, -131.832123f);
            float2 b0 = float2(123.460266f, 359.56012f);
            float2 r0 = float2(9.910767f, -491.392242f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2 a1 = float2(-197.293152f, -485.28656f);
            float2 b1 = float2(-48.2484741f, 478.979065f);
            float2 r1 = float2(-149.044678f, -964.2656f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2 a2 = float2(-337.550323f, 471.6671f);
            float2 b2 = float2(207.158325f, 142.36731f);
            float2 r2 = float2(-544.7086f, 329.2998f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2 a3 = float2(146.506592f, -130.585052f);
            float2 b3 = float2(-125.6055f, -65.29901f);
            float2 r3 = float2(272.1121f, -65.28604f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_sub_wide_scalar()
        {
            float2 a0 = float2(48.9367065f, 410.4516f);
            float b0 = (-291.5904f);
            float2 r0 = float2(340.5271f, 702.042f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2 a1 = float2(-364.4417f, -460.067322f);
            float b1 = (163.980591f);
            float2 r1 = float2(-528.4223f, -624.0479f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2 a2 = float2(110.919434f, 180.269714f);
            float b2 = (204.358337f);
            float2 r2 = float2(-93.4389f, -24.088623f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2 a3 = float2(-377.9257f, 400.5349f);
            float b3 = (-470.262054f);
            float2 r3 = float2(92.3363647f, 870.797f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float2 b0 = float2(452.352539f, 256.9898f);
            float2 r0 = float2(-157.766052f, 37.59668f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-275.159882f);
            float2 b1 = float2(-89.02753f, 488.2284f);
            float2 r1 = float2(-186.132355f, -763.3883f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-333.2173f);
            float2 b2 = float2(-64.233f, -66.04172f);
            float2 r2 = float2(-268.984283f, -267.175568f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (341.204956f);
            float2 b3 = float2(-385.775055f, 75.3947754f);
            float2 r3 = float2(726.98f, 265.810181f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mul_wide_wide()
        {
            float2 a0 = float2(-394.780548f, -412.3722f);
            float2 b0 = float2(-149.763977f, -345.04538f);
            float2 r0 = float2(59123.9063f, 142287.125f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2 a1 = float2(-25.8745728f, -241.045959f);
            float2 b1 = float2(-284.334045f, 267.979248f);
            float2 r1 = float2(7357.022f, -64595.3164f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2 a2 = float2(-93.6759949f, 244.159973f);
            float2 b2 = float2(-326.6485f, -150.689667f);
            float2 r2 = float2(30599.123f, -36792.3867f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2 a3 = float2(494.688477f, 53.5379639f);
            float2 b3 = float2(207.732422f, 366.192871f);
            float2 r3 = float2(102762.836f, 19605.22f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mul_wide_scalar()
        {
            float2 a0 = float2(328.203f, -290.10672f);
            float b0 = (192.211182f);
            float2 r0 = float2(63084.2852f, -55761.7539f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2 a1 = float2(236.995728f, 357.903137f);
            float b1 = (120.481384f);
            float2 r1 = float2(28553.5742f, 43120.6641f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2 a2 = float2(134.867249f, -438.272919f);
            float b2 = (-477.3105f);
            float2 r2 = float2(-64373.55f, 209192.266f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2 a3 = float2(-46.729187f, 422.08252f);
            float b3 = (-238.405f);
            float2 r3 = float2(11140.4717f, -100626.586f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float2 b0 = float2(329.360962f, -198.683441f);
            float2 r0 = float2(-152999.6f, 92295.35f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (184.0794f);
            float2 b1 = float2(256.016174f, 266.226318f);
            float2 r1 = float2(47127.3047f, 49006.78f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-97.8947449f);
            float2 b2 = float2(159.748108f, -351.8222f);
            float2 r2 = float2(-15638.5f, 34441.5469f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (491.801575f);
            float2 b3 = float2(49.90204f, 424.4626f);
            float2 r3 = float2(24541.9f, 208751.375f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_div_wide_wide()
        {
            float2 a0 = float2(246.265747f, -269.85614f);
            float2 b0 = float2(172.119812f, -77.14111f);
            float2 r0 = float2(1.43078089f, 3.49821424f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2 a1 = float2(-451.619537f, -7.388489f);
            float2 b1 = float2(-325.8354f, -450.608673f);
            float2 r1 = float2(1.38603592f, 0.0163966864f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2 a2 = float2(-308.205566f, -373.3948f);
            float2 b2 = float2(-261.262146f, -122.449493f);
            float2 r2 = float2(1.17967939f, 3.04937816f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2 a3 = float2(360.41864f, 25.8097534f);
            float2 b3 = float2(-93.2107849f, -442.005219f);
            float2 r3 = float2(-3.86670542f, -0.0583924167f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_div_wide_scalar()
        {
            float2 a0 = float2(-244.517456f, 69.1123047f);
            float b0 = (-60.0243835f);
            float2 r0 = float2(4.07363558f, -1.15140378f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2 a1 = float2(-333.023132f, 403.2456f);
            float b1 = (257.396851f);
            float2 r1 = float2(-1.293812f, 1.56662989f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2 a2 = float2(154.34436f, -261.8864f);
            float b2 = (131.526611f);
            float2 r2 = float2(1.17348385f, -1.99112868f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2 a3 = float2(-348.9238f, 210.557922f);
            float b3 = (-275.5387f);
            float2 r3 = float2(1.26633322f, -0.764168262f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float2 b0 = float2(-422.676147f, 248.129639f);
            float2 r0 = float2(-0.09874622f, 0.168209136f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (449.391357f);
            float2 b1 = float2(245.858154f, -326.6206f);
            float2 r1 = float2(1.82784808f, -1.37588179f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (163.715088f);
            float2 b2 = float2(333.6645f, 38.2910767f);
            float2 r2 = float2(0.4906578f, 4.27554131f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-472.979767f);
            float2 b3 = float2(192.230164f, -200.296875f);
            float2 r3 = float2(-2.46048665f, 2.36139369f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mod_wide_wide()
        {
            float2 a0 = float2(-442.309875f, 368.5005f);
            float2 b0 = float2(-43.2450562f, -144.195862f);
            float2 r0 = float2(-9.859314f, 80.1087646f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2 a1 = float2(-1.09390259f, -364.673828f);
            float2 b1 = float2(-62.6404724f, -336.828247f);
            float2 r1 = float2(-1.09390259f, -27.8455811f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2 a2 = float2(-197.343933f, -34.0349121f);
            float2 b2 = float2(-154.61026f, -154.029358f);
            float2 r2 = float2(-42.7336731f, -34.0349121f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2 a3 = float2(-101.348572f, 208.318542f);
            float2 b3 = float2(487.0462f, -469.8291f);
            float2 r3 = float2(-101.348572f, 208.318542f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mod_wide_scalar()
        {
            float2 a0 = float2(-433.417f, -5.51412964f);
            float b0 = (-90.49924f);
            float2 r0 = float2(-71.4200439f, -5.51412964f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2 a1 = float2(393.3944f, -120.80603f);
            float b1 = (299.41156f);
            float2 r1 = float2(93.98285f, -120.80603f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2 a2 = float2(-502.939026f, 186.094788f);
            float b2 = (-450.807678f);
            float2 r2 = float2(-52.1313477f, 186.094788f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2 a3 = float2(-84.47363f, 433.4547f);
            float b3 = (-318.7815f);
            float2 r3 = float2(-84.47363f, 114.673218f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float2 b0 = float2(-159.140259f, 230.17334f);
            float2 r0 = float2(-78.14188f, -166.249054f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (14.7793579f);
            float2 b1 = float2(-303.1565f, 399.635f);
            float2 r1 = float2(14.7793579f, 14.7793579f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (206.6947f);
            float2 b2 = float2(397.0448f, -393.890656f);
            float2 r2 = float2(206.6947f, 206.6947f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-372.067078f);
            float2 b3 = float2(201.012268f, -95.566864f);
            float2 r3 = float2(-171.05481f, -85.3664856f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float2_operator_plus()
        {
            float2 a0 = float2(271.670837f, -79.08023f);
            float2 r0 = float2(271.670837f, -79.08023f);
            TestUtils.AreEqual(+a0, r0);

            float2 a1 = float2(-330.985046f, 315.449524f);
            float2 r1 = float2(-330.985046f, 315.449524f);
            TestUtils.AreEqual(+a1, r1);

            float2 a2 = float2(319.222168f, -350.3086f);
            float2 r2 = float2(319.222168f, -350.3086f);
            TestUtils.AreEqual(+a2, r2);

            float2 a3 = float2(-320.518463f, -107.00351f);
            float2 r3 = float2(-320.518463f, -107.00351f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float2_operator_neg()
        {
            float2 a0 = float2(420.227173f, -196.2575f);
            float2 r0 = float2(-420.227173f, 196.2575f);
            TestUtils.AreEqual(-a0, r0);

            float2 a1 = float2(-335.426819f, -33.0144043f);
            float2 r1 = float2(335.426819f, 33.0144043f);
            TestUtils.AreEqual(-a1, r1);

            float2 a2 = float2(-498.575317f, -270.859467f);
            float2 r2 = float2(498.575317f, 270.859467f);
            TestUtils.AreEqual(-a2, r2);

            float2 a3 = float2(19.68689f, -180.600525f);
            float2 r3 = float2(-19.68689f, 180.600525f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float2_operator_prefix_inc()
        {
            float2 a0 = float2(-99.79556f, 458.741821f);
            float2 r0 = float2(-98.79556f, 459.741821f);
            TestUtils.AreEqual(++a0, r0);

            float2 a1 = float2(96.1790161f, -315.728973f);
            float2 r1 = float2(97.1790161f, -314.728973f);
            TestUtils.AreEqual(++a1, r1);

            float2 a2 = float2(-299.230164f, -456.8903f);
            float2 r2 = float2(-298.230164f, -455.8903f);
            TestUtils.AreEqual(++a2, r2);

            float2 a3 = float2(-76.50766f, 64.0965f);
            float2 r3 = float2(-75.50766f, 65.0965f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float2_operator_postfix_inc()
        {
            float2 a0 = float2(322.943542f, 472.0525f);
            float2 r0 = float2(322.943542f, 472.0525f);
            TestUtils.AreEqual(a0++, r0);

            float2 a1 = float2(203.48761f, -31.4205322f);
            float2 r1 = float2(203.48761f, -31.4205322f);
            TestUtils.AreEqual(a1++, r1);

            float2 a2 = float2(455.3366f, 55.7368774f);
            float2 r2 = float2(455.3366f, 55.7368774f);
            TestUtils.AreEqual(a2++, r2);

            float2 a3 = float2(153.7503f, -427.401062f);
            float2 r3 = float2(153.7503f, -427.401062f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float2_operator_prefix_dec()
        {
            float2 a0 = float2(-416.201233f, -96.63788f);
            float2 r0 = float2(-417.201233f, -97.63788f);
            TestUtils.AreEqual(--a0, r0);

            float2 a1 = float2(-50.14566f, 439.479065f);
            float2 r1 = float2(-51.14566f, 438.479065f);
            TestUtils.AreEqual(--a1, r1);

            float2 a2 = float2(-304.400818f, 246.088989f);
            float2 r2 = float2(-305.400818f, 245.088989f);
            TestUtils.AreEqual(--a2, r2);

            float2 a3 = float2(171.964539f, 298.2848f);
            float2 r3 = float2(170.964539f, 297.2848f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float2_operator_postfix_dec()
        {
            float2 a0 = float2(-376.5924f, 16.9697266f);
            float2 r0 = float2(-376.5924f, 16.9697266f);
            TestUtils.AreEqual(a0--, r0);

            float2 a1 = float2(-0.2506714f, 409.557556f);
            float2 r1 = float2(-0.2506714f, 409.557556f);
            TestUtils.AreEqual(a1--, r1);

            float2 a2 = float2(47.85663f, -262.0626f);
            float2 r2 = float2(47.85663f, -262.0626f);
            TestUtils.AreEqual(a2--, r2);

            float2 a3 = float2(-182.405731f, -129.232666f);
            float2 r3 = float2(-182.405731f, -129.232666f);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void float2_shuffle_result_1()
        {
            float2 a = float2(0, 1);
            float2 b = float2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (3));
        }

        [TestCompiler]
        public static void float2_shuffle_result_2()
        {
            float2 a = float2(0, 1);
            float2 b = float2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX), float2(0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftX), float2(1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), float2(2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX), float2(3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY), float2(0, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float2(1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY), float2(2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY), float2(3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX), float2(0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), float2(1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX), float2(2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), float2(3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY), float2(0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightY), float2(1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY), float2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY), float2(3, 3));
        }

        [TestCompiler]
        public static void float2_shuffle_result_3()
        {
            float2 a = float2(0, 1);
            float2 b = float2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY), float3(2, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightX), float3(2, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightY), float3(3, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float3(1, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), float3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), float3(0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY), float3(2, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftX), float3(3, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), float3(2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX), float3(2, 2, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY), float3(3, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float3(0, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightX), float3(3, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightY), float3(0, 1, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float3(3, 1, 1));
        }

        [TestCompiler]
        public static void float2_shuffle_result_4()
        {
            float2 a = float2(0, 1);
            float2 b = float2(2, 3);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX), float4(0, 0, 1, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(2, 1, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightX), float4(3, 2, 3, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.RightY), float4(2, 0, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightX), float4(0, 3, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftY), float4(3, 0, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftX), float4(2, 2, 3, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(2, 2, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.LeftY), float4(0, 1, 2, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightY), float4(2, 1, 3, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.LeftY), float4(3, 3, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float4(2, 2, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), float4(3, 0, 0, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightX, ShuffleComponent.RightY), float4(2, 2, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(0, 3, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftX, ShuffleComponent.LeftX), float4(2, 0, 0, 0));
        }


    }
}
