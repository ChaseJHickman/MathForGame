****_-MathLibrary-_****

***Matrix3.cs***


  **Attributes**:

        Name: m11, m12, m13, m21, m22, m23, m31, m32, m33
             Description: 
             Type:float

        Matrix3()
             Description: The base constructor for the Matrix3 class.
             Type:constructor

        Matrix3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
             Description: The overloaded constructor for the Matrix3 class.
             Type:constructor

        CreateRotation(float radians)
             Description: Creates a new matrix that has been rotated by the given value.
             Type:Matrix3

        CreateTranslation(Vector2 position)
             Description: Creates a new matrix that has been translated by the given value.
             Type:Matrix3

        CreateScale(Vector2 scale)
             Description: Creates a new matrix that has been scaled by the given value.
             Type:Matrix3

        operator +(Matrix3 lhs, Matrix3 rhs)
             Description: Craetes a new matrix that has been added by both sides.
             Type:Matrix3

        operator -(Matrix3 lhs, Matrix3 rhs)
             Description: Creates a new matrix that been subtracted by both sides.
             Type:Matrix3

        operator *(Matrix3 lhs, Matrix3 rhs)
             Description: Creates a new matrix that has been multiplied by both sides.
             Type:Matrix3

        operator *(Matrix3 lhs, Vector3 rhs)
             Description: Creates a new vector by multiplying Matrix3 with Vector3.
             Type:Vector3


   ***Matrix4.cs***


   **Attributes**:

        Name: m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44 
             Description: 
             Type:float

        Matrix4()
             Description: The base constructor for the Matrix4 class.
             Type:constructor

        Matrix4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
             Description: The overloaded constructor for the Matrix4 class.
             Type:constructor

        CreateRotationX(float radians)
             Description: Creates a new matrix that is rotated by the given value on the X-axis.
             Type:Matrix4

        CreateRotationY(float radians)
             Description: Creates a new matrix this is rotated by the given value on the Y-axis.
             Type:Matrix4

        CreateRotationZ(float radians)
             Description: Craetes a new matrix that is rotated by the given value on the Z-axis. 
             Type:Matrix4

        CreateTranslation(Vector2 position)
             Description: Creates a new matrix that has been translated by the given value.
             Type:Matrix4

        CreateScale(Vector2 scale)
             Description: Creates a new matrix that has been scaled by the given value.
             Type:Matrix4

        operator +(Matrix4 lhs, Matrix4 rhs)
             Description: Creates a new matrix that has been added by both sides.
             Type:Matrix4

        operator -(Matrix4 lhs, Matrix4 rhs)
             Description: Creates a new matrix that has been subtracted by both sides.
             Type:Matrix4

        operator *(Matrix4 lhs, Matrix4 rhs)
             Description: Creates a new matrix that has been multiplied by both sides.
             Type:Matrix4

        operator *(Matrix4 lhs, Vector4 rhs)
             Description: Craetes a new vector that has been multiplied by Matrix4 and Vector4.
             Type:Vector4


   ***Vector2.cs***


   **Attributes**:

        _x
             Description: A variable that can hold a value.
             Type:float

        _y
             Description: A variable that can hold a value
             Type:float

        X
             Description: A function that returns the _x variable and gives it value.
             Type:float

        Y
             Description: A function that returns the _y variable and gives it a value.
             Type:float

        Magnitude
             Description: A function that calculates the magnitude of a GameObject.
             Type:float

        Normalized
             Description: A function that returns a normalized variable.
             Type:Vector2

        Normalize(Vector2 vector)
             Description: A function that returns a normalized vector.
             Type:Vector2

        Vector2()
             Description: The base constructor for the Vector2 class.
             Type:constructor

        Vector2(float x, float y)
             Description: The overloaded constructor for the Vector2 class.
             Type:constructor

        DotProduct(Vector2 lhs, Vector2 rhs)
             Description: A function that calculates the product of the Vector2 times itself.
             Type:float

        operator +(Vector2 lhs, Vector2 rhs)
             Description: A function that has been added on both sides.
             Type:Vector2

        operator -(Vector2 lhs, Vector2 rhs)
             Description: A function that has been subtracted on both sides.
             Type:Vector2

        operator *(Vector2 lhs, float scalar)
             Description: A function that has been multiplied by a Vector2 and a scalar.
             Type:Vector2

        operator /(Vector2 lhs, float scalar)
             Description: A function that has been divided by a Vector2 and a scalar.
             Type:Vector2



   ***Vector3.cs***


   **Attributes**:

        _x
             Description: A variable that can hold a value.
             Type:float

        _y
             Description: A variable that can hold a value
             Type:float

        _z
             Description: A variable that can hold a value
             Type:float

        X
             Description: A function that returns the _x variable and gives it value.
             Type:float

        Y
             Description: A function that returns the _y variable and gives it a value.
             Type:float

        Z
             Description: A function that returns the _z variable and gives it a value.
             Type:float

        Magnitude
             Description: A function that calculates the magnitude of a GameObject.
             Type:float

        Normalized
             Description: A function that returns a normalized variable.
             Type:Vector3

        Normalize(Vector3 vector)
             Description: A function that returns a normalized vector.
             Type:Vector3

        Vector3()
             Description: The base constructor for the Vector3 class.
             Type:constructor

        Vector3(float x, float y, float z)
             Description: The overloaded constructor for the Vector3 class.
             Type:constructor

        DotProduct(Vector3 lhs, Vector3 rhs)
             Description: A function that calculates the product of the Vector3 times itself.
             Type:float

        CrossProduct(Vector3 lhs, Vector3 rhs)
             Description: A function that calculates the cross multiplication of the Vector3 times itself.
             Type:float

        operator +(Vector3 lhs, Vector3 rhs)
             Description: A function that has been added on both sides.
             Type:Vector3

        operator -(Vector3 lhs, Vector3 rhs)
             Description: A function that has been subtracted on both sides.
             Type:Vector3

        operator *(Vector3 lhs, float scalar)
             Description: A function that has been multiplied by a Vector3 and a scalar.
             Type:Vector3

        operator *(float scalar, Vector3 lhs)
             Description: A function that has been multiplied by a scalar and a Vector3.
             Type:Vector3

        operator /(Vector3 lhs, float scalar)
             Description: A function that has been divided by a Vector3 and a scalar.
             Type:Vector3


   ***Vector4.cs***


   **Attributes**:

        _x
             Description: A variable that can hold a value.
             Type:float

        _y
             Description: A variable that can hold a value
             Type:float

        _z
             Description: A variable that can hold a value
             Type:float

        _w
             Description: A variable that can hold a value
             Type:float

        X
             Description: A function that returns the _x variable and gives it value.
             Type:float

        Y
             Description: A function that returns the _y variable and gives it a value.
             Type:float

        Z
             Description: A function that returns the _z variable and gives it a value.
             Type:float

        W
             Description: A function that returns the _z variable and gives it a value.
             Type:float

        Magnitude
             Description: A function that calculates the magnitude of a GameObject.
             Type:float

        Normalized
             Description: A function that returns a normalized variable.
             Type:Vector4

        Normalize(Vector4 vector)
             Description: A function that returns a normalized vector.
             Type:Vector4

        Vector4()
             Description: The base constructor for the Vector4 class.
             Type:constructor

        Vector4(float x, float y, float z, float w)
             Description: The overloaded constructor for the Vector4 class.
             Type:constructor

        DotProduct(Vector4 lhs, Vector4 rhs)
             Description: A function that calculates the product of the Vector4 times itself.
             Type:float

        CrossProduct(Vector4 lhs, Vector4 rhs)
             Description: A function that calculates the cross multiplication of the Vector4 times itself.
             Type:float

        operator +(Vector4 lhs, Vector4 rhs)
             Description: A function that has been added on both sides.
             Type:Vector3

        operator -(Vector4 lhs, Vector4 rhs)
             Description: A function that has been subtracted on both sides.
             Type:Vector3

        operator *(Vector4 lhs, float scalar)
             Description: A function that has been multiplied by a Vector4 and a scalar.
             Type:Vector4

        operator *(float scalar, Vector4 lhs)
             Description: A function that has been multiplied by a scalar and a Vector4.
             Type:Vector4

        operator /(Vector4 lhs, float scalar)
             Description: A function that has been divided by a Vector4 and a scalar.
             Type:Vector4

****_-MathForGames-_****

***Actor.cs***

**Attributes**:
         
         Forward
              Description: A function that returns a new Vector2's _globalTruanform.m11 and .m21
              Type:Vector2

         AddChild(Actor child)
              Description: A fucntion that adds a child to the current scene.
              Type:Void

         RemoveChild(Actor child)
              Description: A function that removes a child from the current scene.
              Type:Boolian

         SetTranslate(Vector2 position)
              Description: A function that tells the actor how to translate on the current scene using Matrix3
              Type:Void

         SetRotation(float radians)
              Description: A function that tells the actor how to rotate on the current scene using Matrix3
              Type:Void
              
         SetScale(float x, float y)
              Description: A function that tells the actor how to scale on the current scene using Matrix3
              Type:Void

         CheckCollision(Actor other)
              Description: A function that checks to see if the actor has collided with another actor
              Type:Boolian

         OnCollision(Actor other)
              Description: A function that tells the Actor what to do once collision is detected
              Type:Virtual Void

         UpdateLocalTransform
              Description: A function that updates the actors transform relative to their parent actor
              Type:Void

         UpdateGlobalTransform
              Description: A function that updates the actors transform relative to the current scene
              Type:Void

         WorldPosition
              Description: A function that returns the actors current position in the scene
              Type:Vector2

         LocalPosition
              Description: A function that returns the actors curernt position relative to their parent actor
              Type:Vector2
        
         Velocity
              Description: A function that gets and sets _velocity to a value
              Type:Vector2

         Actor(Float x, float y, Scene scene, char icon = ' ', ConsoleColor color = ConsoleColor.White)
              Description: This constructor defines what an actor inherits
              Type:Constructor

         Start
              Description: A function that is called when the program is run
              Type:Virtual Void

         Update(float deltaTime)
              Description: A function that is called every frame
              Type:Virtual Void

         Draw
              Description: A function that draws everything in the Raylib window
              Type:Virtual Void

         End
              Description: A function that ends the program when called
              Type:Virtual Void

***Game.cs***

**Attributes**:

         SetGameOver(bool value)
              Description: A funtion that tells the program when the game is over
              Type:Static Void

         GetScene(int index)
              Description: A function theat returns _scenes from "index"
              Type:Static Scene

         GetCurrentScene
              Description: A function that returns _scenes from the current scene index
              Type:Static Scene

         AddScene(Scene scene)
              Description: A function that will add a scene into the current scene index
              Type:Static int

         RemoveScene(Scene scene)
              Description: A function that removes a scene from the current scene index
              Type:Static Boolian

         SetCurrentScene(int index)
              Description: A function that sets the current scene from the array of scenes
              Type:Static Void

         GetKeyDown(int key)
              Description: A function that returns what key is being held down
              Type:Static Boolian

         GetKeyPressed(int key)
              Description: A function that returns what key is being pressed
              Type:Static Boolian

         Run
              Description: A function that defines what it means to run the program
              Type:Void

***Enemy.cs***

**Attributes**

         Target
              Description: A function that gets and sets _target to a value
              Type:Actor

         Enemy(float x, float y, Scene scene, char icon = ' ', ConsoleColor color = ConsoleColor.White): base(x, y, icon, color)
              Description: This defines what Enemy inherits from actor
              Type:Constructor

         OnCollision(Actor other)
              Description: A function that tells the Enemy what to do if it colides with an Actor
              Type:Override void

         CheckTargetInSight(float maxAngle, float maxDistance)
              Description: A function that checks if an actor is in front of them
              Type:Boolian

***Goal.cs***

**Attributes**

         Goal(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White): base(x, y, rayColor, icon, color)
              Description: This defines what Goal inherits from Actor
              Type:Constructor

***Scene.cs***

**Attributes**

         World
              Description: This returns _transform
              Type:Matrix3

         AddActor(Actor actor)
              Description: This function adds an actor to the current scene
              Tyep:Void

         RemoveActor(int index)
              Description: This function removes an actor from the current scene
              Type:Boolian

         CheckCollision
              Description: This function checks to see if any collision has happened
              Type:Void