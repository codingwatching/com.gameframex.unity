﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace GameFrameX.Runtime
{
    /// <summary>
    /// 默认 JSON 函数集辅助器。
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    public class NewtonsoftJsonHelper : Utility.Json.IJsonHelper
    {
        /// <summary>
        /// 将对象序列化为 JSON 字符串。
        /// </summary>
        /// <param name="obj">要序列化的对象。</param>
        /// <returns>序列化后的 JSON 字符串。</returns>
        [UnityEngine.Scripting.Preserve]
        public string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 将 JSON 字符串反序列化为对象。
        /// </summary>
        /// <typeparam name="T">对象类型。</typeparam>
        /// <param name="json">要反序列化的 JSON 字符串。</param>
        /// <returns>反序列化后的对象。</returns>
        [UnityEngine.Scripting.Preserve]
        public T ToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 将 JSON 字符串反序列化为对象。
        /// </summary>
        /// <param name="objectType">对象类型。</param>
        /// <param name="json">要反序列化的 JSON 字符串。</param>
        /// <returns>反序列化后的对象。</returns>
        [UnityEngine.Scripting.Preserve]
        public object ToObject(Type objectType, string json)
        {
            return JsonConvert.DeserializeObject(json, objectType);
        }
    }
}