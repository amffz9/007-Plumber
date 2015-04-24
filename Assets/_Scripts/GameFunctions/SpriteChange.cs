using UnityEngine;
using System.Collections;

public class SpriteChange : Character {

    [Header("Movement Sprites")]
    public Sprite running;
    public Sprite still;
    public Sprite jumping;

    private SpriteRenderer picture;
    private float scaleX;
    private Vector3 scale;
    private Vector3 velocity;

	void Awake()
    {
        picture = this.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        /*
         * This is were all the sprite switching is done on the characters
         * */
        velocity = this.rigidbody.velocity;
        
        bool isStill = velocity.x >-.1 && velocity.x <.1;
        if (isStill /*&& OnGround()*/)//changing sprite direction is done in the Character Script
        {
            picture.sprite = still;
        }
        else if(OnGround())
        {
            picture.sprite = running;
        }
        else
        {
            picture.sprite = jumping;
        }
        if (velocity.x < - .1 && facingRight == true)
        {
            switchX();
            facingRight = false;
        }
        if (velocity.x > .1 && facingRight == false)
        {
            switchX();
            facingRight = true;
        }
        CharacterFace();
    }
    public void CharacterFace()
    {
        if (facingRight == false)
        {

            if (transform.localScale.x > 0)
            {
                switchX();
            }
        }
        else
        {
            if (transform.localScale.x < 0)
            {
                switchX();
            }
        }
    }
    public void switchX()
    {
        scaleX = transform.localScale.x;
        scaleX *= -1;
        scale = transform.localScale;
        scale.x = scaleX;
        transform.localScale = scale;
    }
}
