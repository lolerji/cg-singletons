using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CloneGames.Singletons
{
    /// <summary>
    /// Base class for creating non-MonoBehaviour singleton classes by just inheriting
    /// </summary>
    /// <typeparam name="T">The singleton type. i.e AudioManager class</typeparam>
    public abstract class Singleton<T>
        where T : Singleton<T>, new()
    {
        protected Singleton() { }


        private static T __instance;

        public static T Instance => __instance == null ? (__instance = new T()) : __instance;
    }
}
