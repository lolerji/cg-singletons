using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CloneGames.Singletons
{
    /// <summary>
    /// Base class for creating singleton MonoBehaviour scripts by just inheriting
    /// </summary>
    /// <typeparam name="T">Singleton MonoBehaviour class</typeparam>
    public abstract class ComponentSingleton<T> : MonoBehaviour
        where T : ComponentSingleton<T>
    {
        private static T __instance;

        public static T Instance => __instance == null ? (__instance = FindObjectOfType<T>()) : __instance;
    }
}
