using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class on_fire : MonoBehaviour
{

    Stuff[] making_fire;
    private bool exist_match = false;
    private bool exist_paper = false;
    
    private void Awake()
    {
        making_fire = new Stuff[2]; 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Put_the_paper(collision);
        Put_the_fired_match(collision);
        

        if((!exist_match)&& exist_paper)// ������ ���� ���� �ʾҰ�, ���̸� �ִ� ���
        {
            // ������ ���̰� ������.
        }
        else if (exist_match && exist_match)// ������ ���̰� ���̰�, ������ �� ���.
        {
            // ���� �ǿ���.


        }
        else if ((collision.GetType() is Cup)) // ������ ���� ���
        {
            Cup cup=collision.collider.GetComponent<Cup>();
            if (cup.water_is_fulled())// ���� ���ſ� ���� ����� �ִٸ�,
            {
                // ���� ������ Į�� ��Ÿ��.
            }
            
        }




    }

    private void Put_the_paper(Collision2D c)
    {
        if(c.GetType() is Paper)
        {
            making_fire[0]=c.collider.GetComponent<Paper>();
             exist_paper = true;
        }
    }

    private void Put_the_fired_match(Collision2D c)
    {
        if(c.GetType() is Match)
        {
            making_fire[1]=c.collider.GetComponent<Match>();
            exist_match = true;
        }
    }

}
