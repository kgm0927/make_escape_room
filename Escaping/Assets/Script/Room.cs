using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Room : MonoBehaviour
{
    // Start is called before the first frame update
     public Stuff []arounds;
    // �ֺ��� ��� �ִ��� �� �� �ְ� ��.
  


    private void Awake()
    {
    
    }


    private void Update()
    {
   ;
        
        for (int i = 0; i < arounds.Length; i++)
        {
            if (!arounds[i].exist_return())
            {
                Destroy(arounds[i].return_object());
            }
        }
    }


    public void check_the_stuff(Stuff obj)
    {

        for (int i = 0; i < arounds.Length; i++)
        {
            if (arounds[i].GetType() == obj.GetType())
            {
                arounds[i].change_exist_or_not();
             
                arounds[i].delete_self();
            }
        }

        // ���⼭ �� �ȿ� �ִ� ������ Ŭ���ϸ� �迭 �ȿ� �ִ� ����
        // �����ǵ��� ��.
        //
    }

}
