﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MotionInterpolation.maths
{
    public class EulerToQuaternionConverter
    {
        /// <summary>
        /// We Assume that angles are in radians
        /// </summary>
        /// <param name="heading"></param>
        /// <param name="attitude"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        public Quaternion Convert(double heading, double attitude, double bank)
        {
            double c1 = Math.Cos(heading / 2);
            double s1 = Math.Sin(heading / 2);
            double c2 = Math.Cos(attitude / 2);
            double s2 = Math.Sin(attitude / 2);
            double c3 = Math.Cos(bank / 2);
            double s3 = Math.Sin(bank / 2);
            double c1c2 = c1 * c2;
            double s1s2 = s1 * s2;
            double w = c1c2 * c3 - s1s2 * s3;
            double x = c1c2 * s3 + s1s2 * c3;
            double y = s1 * c2 * c3 + c1 * s2 * s3;
            double z = c1 * s2 * c3 - s1 * c2 * s3;

            return new Quaternion(x, y, z, w);
        }

        public Matrix3D BuildMatrix3DFromQuaternion(Quaternion q)
        {
            double sqw = q.W * q.W;
            double sqx = q.X * q.X;
            double sqy = q.Y * q.Y;
            double sqz = q.Z * q.Z;

            // invs (inverse square length) is only required if quaternion is not already normalised
            double invs = 1 / (sqx + sqy + sqz + sqw);
            double m00 = (sqx - sqy - sqz + sqw) * invs; // since sqw + sqx + sqy + sqz =1/invs*invs
            double m11 = (-sqx + sqy - sqz + sqw) * invs;
            double m22 = (-sqx - sqy + sqz + sqw) * invs;

            double tmp1 = q.X * q.Y;
            double tmp2 = q.Z * q.W;
            double m10 = 2.0 * (tmp1 + tmp2) * invs;
            double m01 = 2.0 * (tmp1 - tmp2) * invs;

            tmp1 = q.X * q.Z;
            tmp2 = q.Y * q.W;
            double m20 = 2.0 * (tmp1 - tmp2) * invs;
            double m02 = 2.0 * (tmp1 + tmp2) * invs;
            tmp1 = q.Y * q.Z;
            tmp2 = q.X * q.W;
            double m21 = 2.0 * (tmp1 + tmp2) * invs;
            double m12 = 2.0 * (tmp1 - tmp2) * invs;

            return new Matrix3D(
                m00, m01, m02, 0,
                m10, m11, m12, 0,
                m20, m21, m22, 0,
                0, 0, 0, 1
                );
        }

    }
}
