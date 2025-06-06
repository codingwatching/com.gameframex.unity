﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace GameFrameX.Runtime
{
    /// <summary>
    /// System.Double 变量类。
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    public sealed class VarDouble : Variable<double>
    {
        /// <summary>
        /// 初始化 System.Double 变量类的新实例。
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public VarDouble()
        {
        }

        /// <summary>
        /// 从 System.Double 到 System.Double 变量类的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        [UnityEngine.Scripting.Preserve]
        public static implicit operator VarDouble(double value)
        {
            VarDouble varValue = ReferencePool.Acquire<VarDouble>();
            varValue.Value = value;
            return varValue;
        }

        /// <summary>
        /// 从 System.Double 变量类到 System.Double 的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        [UnityEngine.Scripting.Preserve]
        public static implicit operator double(VarDouble value)
        {
            return value.Value;
        }
    }
}
