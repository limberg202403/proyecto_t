﻿using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentk.utilidades
{
    static class Converter
    {
        public static Vector3[] ParseToVector3Array(float[] vertices)
        {
            List<Vector3> array = new();
            for (int i = 0; i < vertices.Length; i += 3)
            {
                float x, y, z;
                x = vertices[i];
                y = vertices[i + 1];
                z = vertices[i + 2];
                Vector3 vector = new(x, y, z);
                array.Add(vector);
            }

            return array.ToArray();

        }
    }
}
