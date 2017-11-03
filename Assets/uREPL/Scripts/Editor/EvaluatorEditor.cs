namespace uREPL
{
    using UnityEngine;

    /// <summary>
    /// Unity Editor code.
    /// </summary>
    public static class EvaluatorEditor
    {
        [UnityEditor.MenuItem("Assets/Create/uREPL")]
        [UnityEditor.MenuItem("GameObject/Create Other/uREPL")]
        public static void Create()
        {
            var prefab = Resources.Load("uREPL/Prefabs/uREPL");
            var instance = Object.Instantiate(prefab);
            instance.name = "uREPL";
        }
    }
}