using UnityEngine.SceneManagement;

namespace Kogane
{
    public static class SceneReloader
    {
        public static void ReloadScene()
        {
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
    }
}