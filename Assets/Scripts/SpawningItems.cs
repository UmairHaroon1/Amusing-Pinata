using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawningItems : MonoBehaviour
{
    public static SpawningItems Instance;
    public List<GameObject> PrefabItems;
    public float Spawningtime=0.1f;

    public Transform SpawnPos;
    // Start is called before the first frame update
   public void StartSpawn()
    {
        StartCoroutine(Spawming());
    }

   private void Awake()
   {
       Instance = this;
   }

   public SpriteRenderer sp;
   private void Update()
    {
        
    }

   public List<ParticleSystem> P;
    IEnumerator Spawming()
    {
        P[Session.Instance.ChoosenPinata].Play();
        sp.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        SoundManager.Instance.BtnClick(SoundManager.Instance.Explode);
        int RandomSpawner=Random.Range(5,11);
        for (int i = 0; i <RandomSpawner; i++)
        {
            yield return new WaitForSeconds(Spawningtime);

            Spawningitem();
        }

        this.Invoke(() =>
        {
            sp.maskInteraction = SpriteMaskInteraction.None;

        }, 1f);

       // while (!CanvasManager.isgameover)
        
           
        
    }
    public  void Spawningitem()
    {
       int RandonSpawn= Random.Range(0,PrefabItems.Count);
        
        Instantiate(PrefabItems[RandonSpawn],SpawnPos.position,Quaternion.identity);
        
    }
}
