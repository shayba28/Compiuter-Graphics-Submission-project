using System;
using System.Collections.Generic;
using System.Windows.Forms;

//2
using System.Drawing;

namespace OpenGL
{
    class cOGL
    {
        Control p;
        int Width;
        int Height;
        float h;
        float h_x;
        float h_y;
        float h_z;

        public int intOptionA = 1;

        GLUquadric obj;

        public cOGL(Control pb)
        {
            
            p = pb;
            Width = p.Width;
            Height = p.Height;

            intOptionA = 1;
            intOptionC = 1;

            cought = false;

            move[0] = move[1] = move[2] = 0;

            ground[0,0] = 1;
            ground[0,1] = 1;
            ground[0,2] = -0.005f;

            ground[1,0] = 0;
            ground[1,1] = 1;
            ground[1,2] = -0.005f;

            ground[2,0] = 1;
            ground[2,1] = 0;
            ground[2,2] = -0.005f;

            wall[0, 0] = -1;
            wall[0, 1] = 9.95f;
            wall[0, 2] = 0;

            wall[1, 0] = 1;
            wall[1, 1] = 9.95f;
            wall[1, 2] = 0;

            wall[2, 0] = 1;
            wall[2, 1] = 9.95f;
            wall[2, 2] = 1;

            wall2[0, 0] = -1;
            wall2[0, 1] = 9.95f;
            wall2[0, 2] = 0;

            wall2[1, 0] = 1;
            wall2[1, 1] = 9.95f;
            wall2[1, 2] = 0;

            wall2[2, 0] = 1;
            wall2[2, 1] = 9.95f;
            wall2[2, 2] = 1;

            wall3[0, 0] = -1;
            wall3[0, 1] = 9.95f;
            wall3[0, 2] = 0;

            wall3[1, 0] = 1;
            wall3[1, 1] = 9.95f;
            wall3[1, 2] = 0;

            wall3[2, 0] = 1;
            wall3[2, 1] = 9.95f;
            wall3[2, 2] = 1;


            wall4[0, 0] = -1;
            wall4[0, 1] = 9.95f;
            wall4[0, 2] = 0;

            wall4[1, 0] = 1;
            wall4[1, 1] = 9.95f;
            wall4[1, 2] = 0;

            wall4[2, 0] = 1;
            wall4[2, 1] = 9.95f;
            wall4[2, 2] = 1;



            wallC[0, 0] = -1;
            wallC[0, 1] = 9.95f;
            wallC[0, 2] = 0;

            wallC[1, 0] = 1;
            wallC[1, 1] = 9.95f;
            wallC[1, 2] = 0;

            wallC[2, 0] = 1;
            wallC[2, 1] = 9.95f;
            wallC[2, 2] = 1;

            wall2C[0, 0] = -1;
            wall2C[0, 1] = 9.95f;
            wall2C[0, 2] = 0;

            wall2C[1, 0] = 1;
            wall2C[1, 1] = 9.95f;
            wall2C[1, 2] = 0;

            wall2C[2, 0] = 1;
            wall2C[2, 1] = 9.95f;
            wall2C[2, 2] = 1;

            wall3C[0, 0] = -1;
            wall3C[0, 1] = 9.95f;
            wall3C[0, 2] = 0;

            wall3C[1, 0] = 1;
            wall3C[1, 1] = 9.95f;
            wall3C[1, 2] = 0;

            wall3C[2, 0] = 1;
            wall3C[2, 1] = 9.95f;
            wall3C[2, 2] = 1;


            wall4C[0, 0] = -1;
            wall4C[0, 1] = 9.95f;
            wall4C[0, 2] = 0;

            wall4C[1, 0] = 1;
            wall4C[1, 1] = 9.95f;
            wall4C[1, 2] = 0;

            wall4C[2, 0] = 1;
            wall4C[2, 1] = 9.95f;
            wall4C[2, 2] = 1;

            wall4C[0, 0] = -1;
            wall4C[0, 1] = 9.95f;
            wall4C[0, 2] = 0;

            wall4C[1, 0] = 1;
            wall4C[1, 1] = 9.95f;
            wall4C[1, 2] = 0;

            wall4C[2, 0] = 1;
            wall4C[2, 1] = 9.95f;
            wall4C[2, 2] = 1;

            cubeW[0, 0] = -1;
            cubeW[0, 1] = 9.95f;
            cubeW[0, 2] = 0;

            cubeW[1, 0] = 1;
            cubeW[1, 1] = 9.95f;
            cubeW[1, 2] = 0;

            cubeW[2, 0] = 1;
            cubeW[2, 1] = 9.95f;
            cubeW[2, 2] = 1;

            cubeW2[0, 0] = -1;
            cubeW2[0, 1] = 9.95f;
            cubeW2[0, 2] = 0;

            cubeW2[1, 0] = 1;
            cubeW2[1, 1] = 9.95f;
            cubeW2[1, 2] = 0;

            cubeW2[2, 0] = 1;
            cubeW2[2, 1] = 9.95f;
            cubeW2[2, 2] = 1;

            cubeW3[0, 0] = -1;
            cubeW3[0, 1] = 9.95f;
            cubeW3[0, 2] = 0;

            cubeW3[1, 0] = 1;
            cubeW3[1, 1] = 9.95f;
            cubeW3[1, 2] = 0;

            cubeW3[2, 0] = 1;
            cubeW3[2, 1] = 9.95f;
            cubeW3[2, 2] = 1;

            cubeW4[0, 0] = -1;
            cubeW4[0, 1] = 9.95f;
            cubeW4[0, 2] = 0;

            cubeW4[1, 0] = 1;
            cubeW4[1, 1] = 9.95f;
            cubeW4[1, 2] = 0;

            cubeW4[2, 0] = 1;
            cubeW4[2, 1] = 9.95f;
            cubeW4[2, 2] = 1;


            isSolid = true;

            InitializeGL();
            obj = GLU.gluNewQuadric(); //!!!

            viewAngle = 45;

            PrepareLists();
            PrepareListsforShade();

            random_cube_place();
        }

        ~cOGL()
        {
            GLU.gluDeleteQuadric(obj); //!!!
            WGL.wglDeleteContext(m_uint_RC);
        }

        uint m_uint_HWND = 0;

        public uint HWND
        {
            get { return m_uint_HWND; }
        }

        uint m_uint_DC = 0;

        public uint DC
        {
            get { return m_uint_DC; }
        }
        uint m_uint_RC = 0;

        public uint RC
        {
            get { return m_uint_RC; }
        }


        void DrawOldAxes()
        {
            //for this time
            //Lights positioning is here!!!
            float[] pos = new float[4];
            pos[0] = 10; pos[1] = 10; pos[2] = 10; pos[3] = 1;
            GL.glLightfv(GL.GL_LIGHT0, GL.GL_POSITION, pos);
            GL.glDisable(GL.GL_LIGHTING);

            //INITIAL axes
            GL.glEnable(GL.GL_LINE_STIPPLE);
            GL.glLineStipple(1, 0xFF00);  //  dotted   
            GL.glBegin(GL.GL_LINES);
            //x  RED
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(-3.0f, 0.0f, 0.0f);
            GL.glVertex3f(3.0f, 0.0f, 0.0f);
            //y  GREEN 
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.0f, -3.0f, 0.0f);
            GL.glVertex3f(0.0f, 3.0f, 0.0f);
            //z  BLUE
            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, -3.0f);
            GL.glVertex3f(0.0f, 0.0f, 3.0f);
            GL.glEnd();
            GL.glDisable(GL.GL_LINE_STIPPLE);
        }
        void DrawAxes()
        {
            GL.glBegin(GL.GL_LINES);
            //x  RED
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(-3.0f, 0.0f, 0.0f);
            GL.glVertex3f(3.0f, 0.0f, 0.0f);
            //y  GREEN 
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.0f, -3.0f, 0.0f);
            GL.glVertex3f(0.0f, 3.0f, 0.0f);
            //z  BLUE
            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, -3.0f);
            GL.glVertex3f(0.0f, 0.0f, 3.0f);
            GL.glEnd();
        }

public int viewAngle;
float oldViewAngle = 0.0f;
float []planeCoeff={1,1,1,1};
float[,] ground = new float [3,3];//{ { 1, 1, -0.5 }, { 0, 1, -0.5 }, { 1, 0, -0.5 } };
public float[,] wall = new float [3,3];//{ { -15, 3, 0 }, { 15, 3, 0 }, { 15, 3, 15 } };
public float[,] wall2 = new float [3,3];
public float[,] wall3 = new float [3,3];
public float[,] wall4 = new float[3, 3];

        float[,] wallC = new float[3, 3];//{ { -15, 3, 0 }, { 15, 3, 0 }, { 15, 3, 15 } };
        float[,] wall2C = new float[3, 3];
        float[,] wall3C = new float[3, 3];
        float[,] wall4C = new float[3, 3];

       public float[,] cubeW = new float[3, 3];//{ { -15, 3, 0 }, { 15, 3, 0 }, { 15, 3, 15 } };
       public float[,] cubeW2 = new float[3, 3];
       public float[,] cubeW3 = new float[3, 3];
       public float[,] cubeW4 = new float[3, 3];


        // Reduces a normal vector specified as a set of three coordinates,
        // to a unit normal vector of length one.
        void ReduceToUnit(float []vector)
	{
	float length;
	
	// Calculate the length of the vector		
	length = (float)Math.Sqrt((vector[0]*vector[0]) + 
						(vector[1]*vector[1]) +
						(vector[2]*vector[2]));

	// Keep the program from blowing up by providing an exceptable
	// value for vectors that may calculated too close to zero.
	if(length == 0.0f)
		length = 1.0f;

	// Dividing each element by the length will result in a
	// unit normal vector.
	vector[0] /= length;
	vector[1] /= length;
	vector[2] /= length;
	}
    
	const int x = 0;
	const int y = 1;
	const int z = 2;

// Points p1, p2, & p3 specified in counter clock-wise order
void calcNormal(float [,]v, float []outp)
	{
	float []v1=new float[3];
	float []v2=new float[3];

	// Calculate two vectors from the three points
	v1[x] = v[0,x] - v[1,x];
	v1[y] = v[0,y] - v[1,y];
	v1[z] = v[0,z] - v[1,z];

	v2[x] = v[1,x] - v[2,x];
	v2[y] = v[1,y] - v[2,y];
	v2[z] = v[1,z] - v[2,z];

	// Take the cross product of the two vectors to get
	// the normal vector which will be stored in out
	outp[x] = v1[y]*v2[z] - v1[z]*v2[y];
	outp[y] = v1[z]*v2[x] - v1[x]*v2[z];
	outp[z] = v1[x]*v2[y] - v1[y]*v2[x];

	// Normalize the vector (shorten length to one)
	ReduceToUnit(outp);
	}

    float[] cubeXform = new float[16];

// Creates a shadow projection matrix out of the plane equation
// coefficients and the position of the light. The return value is stored
// in cubeXform[,]
void MakeShadowMatrix(float[,]points)
	{
	float []planeCoeff=new float[4];
	float dot;

	// Find the plane equation coefficients
	// Find the first three coefficients the same way we
	// find a normal.
	calcNormal(points,planeCoeff);

	// Find the last coefficient by back substitutions
	planeCoeff[3] = - (
		(planeCoeff[0]*points[2,0]) + (planeCoeff[1]*points[2,1]) +
		(planeCoeff[2]*points[2,2]));


	// Dot product of plane and light position
	dot = planeCoeff[0] * pos[0] +
			planeCoeff[1] * pos[1] +
			planeCoeff[2] * pos[2] +
			planeCoeff[3];

	// Now do the projection
	// First column
    cubeXform[0] = dot - pos[0] * planeCoeff[0];
    cubeXform[4] = 0.0f - pos[0] * planeCoeff[1];
    cubeXform[8] = 0.0f - pos[0] * planeCoeff[2];
    cubeXform[12] = 0.0f - pos[0] * planeCoeff[3];

	// Second column
	cubeXform[1] = 0.0f - pos[1] * planeCoeff[0];
	cubeXform[5] = dot - pos[1] * planeCoeff[1];
	cubeXform[9] = 0.0f - pos[1] * planeCoeff[2];
	cubeXform[13] = 0.0f - pos[1] * planeCoeff[3];

	// Third Column
	cubeXform[2] = 0.0f - pos[2] * planeCoeff[0];
	cubeXform[6] = 0.0f - pos[2] * planeCoeff[1];
	cubeXform[10] = dot - pos[2] * planeCoeff[2];
	cubeXform[14] = 0.0f - pos[2] * planeCoeff[3];

	// Fourth Column
	cubeXform[3] = 0.0f - pos[3] * planeCoeff[0];
	cubeXform[7] = 0.0f - pos[3] * planeCoeff[1];
	cubeXform[11] = 0.0f - pos[3] * planeCoeff[2];
	cubeXform[15] = dot - pos[3] * planeCoeff[3];
	}
//Shadows


        public bool isSolid = true;

        void DrawLightSource()
        {
            //!!!!!!!!!!!!!
            GL.glPushMatrix();
            //!!!!!!!!!!!!!
            

            //Draw Light Source
            GL.glDisable(GL.GL_LIGHTING);
            GL.glTranslatef(pos[0], pos[1], pos[2]);
            //Yellow Light source
            GL.glColor3f(1, 1, 0);
            GLUT.glutSolidSphere(0.05, 8, 8);
            GL.glTranslatef(-pos[0], -pos[1], -pos[2]);
            //projection line from source to plane
            GL.glBegin(GL.GL_LINES);
            GL.glColor3d(0.5, 0.5, 0);
            GL.glVertex3d(pos[0], pos[1], ground[0, 2] - 0.01);
            GL.glVertex3d(pos[0], pos[1], pos[2]);
            GL.glEnd();

            //end of regular show
            //!!!!!!!!!!!!!
            GL.glPopMatrix();
            //!!!!!!!!!!!!!

        }

        void DrawFloor()
        {
            GL.glPushMatrix();

            GL.glEnable(GL.GL_LIGHTING);
            GL.glBegin(GL.GL_QUADS);
            //!!! for blended REFLECTION 
            GL.glColor4d(0, 0, 1, 0.5);
            
            GL.glVertex3d(-3, -3, 0);
            GL.glVertex3d(-3, 3, 0);
            GL.glVertex3d(3, 3, 0);
            GL.glVertex3d(3, -3, 0);
            GL.glEnd();

            GL.glPopMatrix();
        }

        void reflection_cube() 
        {

            GL.glEnable(GL.GL_BLEND);
            GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);


            //only floor, draw only to STENCIL buffer
            GL.glEnable(GL.GL_STENCIL_TEST);
            GL.glStencilOp(GL.GL_REPLACE, GL.GL_REPLACE, GL.GL_REPLACE);
            GL.glStencilFunc(GL.GL_ALWAYS, 1, 0xFFFFFFFF); // draw floor always
            GL.glColorMask((byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE);
            GL.glDisable(GL.GL_DEPTH_TEST);

            GL.glEnable(GL.GL_CULL_FACE);
           // GL.glCullFace(GL.GL_BACK);
            // DrawFloor();
            GL.glCullFace(GL.GL_FRONT);
            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glVertex3f(-0.5f, 0.5f, 1.0f);

            GL.glVertex3f(-0.5f, -0.5f, 1.0f);

            GL.glVertex3f(0.5f, -0.5f, 1.0f);
            GL.glDisable(GL.GL_CULL_FACE);

            //double[] clipPlane0 = new double[4];

            clipPlane0[0] = 0;
            clipPlane0[1] = 0;
            clipPlane0[2] = -1;
            clipPlane0[3] = 0;

            GL.glClipPlane(GL.GL_CLIP_PLANE0, clipPlane0);

            // restore regular settings
            GL.glColorMask((byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE);
            GL.glEnable(GL.GL_DEPTH_TEST);

            // reflection is drawn only where STENCIL buffer value equal to 1
            GL.glStencilFunc(GL.GL_EQUAL, 1, 0xFFFFFFFF);
            GL.glStencilOp(GL.GL_KEEP, GL.GL_KEEP, GL.GL_KEEP);

            GL.glEnable(GL.GL_STENCIL_TEST);

            // draw reflected scene
            GL.glPushMatrix();
            GL.glScalef(1, 1, -1); //swap on Z axis  
            GL.glEnable(GL.GL_CLIP_PLANE0);

            GL.glTranslated(-point[0], -point[1], 0);
            GL.glTranslatef(move[0], move[1], 0);
            GL.glTranslatef(0, 0, 1);
            DrawRobot();
            GL.glTranslatef(-move[0], -move[1], 0);
            GL.glTranslatef(0, 0, -1);
            GL.glTranslated(point[0], point[1], 0);

            GL.glDisable(GL.GL_CLIP_PLANE0);
            GL.glPopMatrix();


            // really draw floor 
            //( half-transparent ( see its color's alpha byte)))
            // in order to see reflected objects 

            // Disable GL.GL_STENCIL_TEST to show All, else it will be cut on GL.GL_STENCIL
            GL.glDisable(GL.GL_STENCIL_TEST);

        }
        
        void DrawmirrorCube()
        {

            GL.glPushMatrix();

            GL.glEnable(GL.GL_BLEND);

            GL.glEnable(GL.GL_LIGHTING);

            GL.glColor4f(0, 0, 1, 0.5f);

            GL.glBegin(GL.GL_QUADS);


            //1

            
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

           
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);

            
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            
            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            //2

            
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

           
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);

            GL.glVertex3f(-0.5f, 0.5f, 1.0f);

            GL.glVertex3f(-0.5f, 0.5f, 0.0f);


            //3

            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            GL.glVertex3f(0.5f, -0.5f, 1.0f);

            GL.glVertex3f(-0.5f, -0.5f, 1.0f);


            //4

            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            GL.glVertex3f(0.5f, -0.5f, 1.0f);

            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glVertex3f(0.5f, 0.5f, 0.0f);


            //5

           
            GL.glVertex3f(0.5f, 0.5f, 1.0f);
           
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            GL.glVertex3f(-0.5f, 0.5f, 0.0f);

            GL.glVertex3f(-0.5f, 0.5f, 1.0f);


            //6

            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glVertex3f(-0.5f, 0.5f, 1.0f);

            GL.glVertex3f(-0.5f, -0.5f, 1.0f);

            GL.glVertex3f(0.5f, -0.5f, 1.0f);


            GL.glEnd();

           // GL.glDisable(GL.GL_BLEND);

            GL.glPopMatrix();

        }

        void DrawCube()
        {

            GL.glPushMatrix();

            GL.glEnable(GL.GL_LIGHTING);

            GL.glBegin(GL.GL_QUADS);

            GL.glColor3d(0, 0, 1);

            GL.glBegin(GL.GL_QUADS);


            //1

            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);

            GL.glColor3f(1.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            //2

            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);

            GL.glColor3f(0.0f, 1.0f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);

            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);


            //3

            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);

            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            GL.glColor3f(1.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);


            //4

            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            GL.glColor3f(1.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glColor3f(1.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);


            //5

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glColor3f(1.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);

            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);

            GL.glColor3f(0.0f, 1.0f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);


            //6

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 1.0f);

            GL.glColor3f(0.0f, 1.0f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);

            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);

            GL.glColor3f(1.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);


            GL.glEnd();

            GL.glPopMatrix();

        }

        void DrawshadeCube()
        {

            GL.glPushMatrix();

           // GL.glEnable(GL.GL_LIGHTING);

            GL.glBegin(GL.GL_QUADS);

            GL.glColor3d(0, 0, 0);

            GL.glBegin(GL.GL_QUADS);


            //1

           
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 0.0f);

            //2

            
            GL.glVertex3f(-0.5f, -0.5f, 0.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);


            //3

            GL.glVertex3f(-0.5f, -0.5f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);


            //4

            GL.glVertex3f(0.5f, -0.5f, 0.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);


            //5

            GL.glVertex3f(0.5f, 0.5f, 1.0f);
            GL.glVertex3f(0.5f, 0.5f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 0.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);


            //6

            GL.glVertex3f(0.5f, 0.5f, 1.0f);
            GL.glVertex3f(-0.5f, 0.5f, 1.0f);
            GL.glVertex3f(-0.5f, -0.5f, 1.0f);
            GL.glVertex3f(0.5f, -0.5f, 1.0f);


            GL.glEnd();

            GL.glPopMatrix();

        }

        void DrawReflection()
        {

            GL.glEnable(GL.GL_BLEND);
            GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);


            //only floor, draw only to STENCIL buffer
            GL.glEnable(GL.GL_STENCIL_TEST);
            GL.glStencilOp(GL.GL_REPLACE, GL.GL_REPLACE, GL.GL_REPLACE);
            GL.glStencilFunc(GL.GL_ALWAYS, 1, 0xFFFFFFFF); // draw floor always
            GL.glColorMask((byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE);
            GL.glDisable(GL.GL_DEPTH_TEST);

            GL.glEnable(GL.GL_CULL_FACE);
            GL.glCullFace(GL.GL_FRONT);
            DrawFloor();
            GL.glDisable(GL.GL_CULL_FACE);

            clipPlane0[0] = 0;
            clipPlane0[1] = 0;
            clipPlane0[2] = -1;
            clipPlane0[3] = 0;

            GL.glClipPlane(GL.GL_CLIP_PLANE0, clipPlane0);

            // restore regular settings
            GL.glColorMask((byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE);
            GL.glEnable(GL.GL_DEPTH_TEST);

            // reflection is drawn only where STENCIL buffer value equal to 1
            GL.glStencilFunc(GL.GL_EQUAL, 1, 0xFFFFFFFF);
            GL.glStencilOp(GL.GL_KEEP, GL.GL_KEEP, GL.GL_KEEP);

            GL.glEnable(GL.GL_STENCIL_TEST);

            // draw reflected scene
            GL.glPushMatrix();
            GL.glScalef(1, 1, -1); //swap on Z axis

            
            
            GL.glTranslatef(move[0], move[1], 0);
            GL.glEnable(GL.GL_CLIP_PLANE0);
            DrawRobot();
            GL.glDisable(GL.GL_CLIP_PLANE0);
            GL.glTranslatef(-move[0], -move[1], 0);

            if (!cought) 
            { 
             GL.glTranslated(point[0], point[1], 0);
             DrawCube();
             GL.glTranslated(-point[0], -point[1], 0);
            }
            

            GL.glPopMatrix();

            // really draw floor 
            //( half-transparent ( see its color's alpha byte)))
            // in order to see reflected objects 
           
            // Disable GL.GL_STENCIL_TEST to show All, else it will be cut on GL.GL_STENCIL
            GL.glDisable(GL.GL_STENCIL_TEST);
            //GL.glDisable(GL.GL_BLEND);

        }
        

        void DrawBlendFloor()
        {
            GL.glEnable(GL.GL_BLEND);
            GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);


            //only floor, draw only to STENCIL buffer
            GL.glEnable(GL.GL_STENCIL_TEST);
            GL.glStencilOp(GL.GL_REPLACE, GL.GL_REPLACE, GL.GL_REPLACE);
            GL.glStencilFunc(GL.GL_ALWAYS, 1, 0xFFFFFFFF); // draw floor always
            GL.glColorMask((byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE, (byte)GL.GL_FALSE);
            GL.glDisable(GL.GL_DEPTH_TEST);

            // restore regular settings
            GL.glColorMask((byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE, (byte)GL.GL_TRUE);
            GL.glEnable(GL.GL_DEPTH_TEST);

            // reflection is drawn only where STENCIL buffer value equal to 1
            GL.glStencilFunc(GL.GL_EQUAL, 1, 0xFFFFFFFF);
            GL.glStencilOp(GL.GL_KEEP, GL.GL_KEEP, GL.GL_KEEP);

            GL.glEnable(GL.GL_STENCIL_TEST);

            // draw reflected scene
            GL.glPushMatrix();
            GL.glScalef(1, 1, -1); //swap on Z axis
            //GL.glRotatef(180, 0, 1, 0);
            //DrawRobot();
            //GL.glRotatef(-180, 0, 1, 0);
            GL.glPopMatrix();


            // really draw floor 
            //( half-transparent ( see its color's alpha byte)))
            // in order to see reflected objects 
            GL.glDepthMask((byte)GL.GL_FALSE);
            // GL.glDisable(GL.GL_BLEND);

            DrawFloor();

            GL.glDepthMask((byte)GL.GL_TRUE);
            // Disable GL.GL_STENCIL_TEST to show All, else it will be cut on GL.GL_STENCIL
            GL.glDisable(GL.GL_STENCIL_TEST);
            //GL.glDisable(GL.GL_BLEND);
        }

        int c;
        void  random_cube_place()
        {
            do
            {
                Random rn = new Random();

                //random cube place
                //if (2.1 > move[0] && move[0] > -2.1 && 2.1 > move[1] && move[1] > -2.1)
                if( point[0] > -3 + 0.5 && 3 - 0.5 > move[0] && move[1] > -3 + 0.5 && 3 - 0.5 > move[1])
                {
                    point[0] = (rn.NextDouble() * (2 * (size - 0.5))) - (size - 0.5);
                    point[1] = (rn.NextDouble() * (2 * (size - 0.5))) - (size - 0.5);

                    magnet_cube_point[0] = point[0];
                    magnet_cube_point[1] = point[1];
                    magnet_cube_point[2] = 1;

                    cubeW[0, 1] = (float)point[1] - 0.51f;
                    cubeW[1, 1] = (float)point[1] - 0.51f;
                    cubeW[2, 1] = (float)point[1] - 0.51f;

                    cubeW2[0, 1] = (float)point[0] - 0.51f;
                    cubeW2[1, 1] = (float)point[0] - 0.51f;
                    cubeW2[2, 1] = (float)point[0] - 0.51f;

                    cubeW3[0, 1] = -((float)point[1] + 0.51f);
                    cubeW3[1, 1] = -((float)point[1] + 0.51f);
                    cubeW3[2, 1] = -((float)point[1] + 0.51f);

                    cubeW4[0, 1] = -((float)point[0] + 0.51f);
                    cubeW4[1, 1] = -((float)point[0] + 0.51f);
                    cubeW4[2, 1] = -((float)point[0] + 0.51f);

                }
            } while (point[0] == move[0] && point[1] == move[1] && !check_distance());
        
        }
        
        void DrawWallShadows(float shadow_angle, float[,] Wall)
        {

            float temp;
            int i;
            // wall shadow
            //!!!!!!!!!!!!!
            GL.glPushMatrix();
            //!!!!!!!!!!!!       


            for (i = 0; shadow_angle > i; i += 90)
            {
                pos[0] *= -1;
                temp = pos[0];
                pos[0] = pos[1];
                pos[1] = temp;
            }
            GL.glRotatef(shadow_angle, 0, 0, 1);

            
            MakeShadowMatrix(Wall);
            GL.glMultMatrixf(cubeXform);



            if (c == 'r')
            {
                ROBOT_angle -= shadow_angle;

                GL.glRotatef(ROBOT_angle, 0, 0, 1);
                GL.glCallList(ROBOT_LIST_FOR_SHADE);
                ROBOT_angle += shadow_angle;
            }

            else
            {
                GL.glRotatef(-shadow_angle, 0, 0, 1);
                DrawshadeCube();
                GL.glRotatef(shadow_angle, 0, 0, 1);
            }


            GL.glRotatef(-shadow_angle, 0, 0, 1);
           

            for (i = 0; shadow_angle > i; i += 90)
            {
                pos[1] *= -1;
                temp = pos[0];
                pos[0] = pos[1];
                pos[1] = temp;
            }
            //!!!!!!!!!!!!!
            GL.glPopMatrix();
            //!!!!!!!!!!!!! 

           
        }

        void DrawGraoundShadows()
        {

            //SHADING begin
            //we'll define cubeXform matrix in MakeShadowMatrix Sub
            // Disable lighting, we'll just draw the shadow
            //else instead of shadow we'll see stange projection of the same objects
            GL.glDisable(GL.GL_LIGHTING);

            // floor shadow
            //!!!!!!!!!!!!!
            GL.glPushMatrix();
            //!!!!!!!!!!!!    		
            MakeShadowMatrix(ground);
            GL.glMultMatrixf(cubeXform);


            if (c == 'r')
            {

                GL.glRotatef(ROBOT_angle, 0, 0, 1);
                GL.glCallList(ROBOT_LIST_FOR_SHADE);

            }

            else
                DrawshadeCube();


            //!!!!!!!!!!!!!
            GL.glPopMatrix();
            //!!!!!!!!!!!!!





        }

        void rotate_point(float angle) 
        {
            double rand_angle;
            rand_angle = angle * Math.PI / 180;
            magnet_robot_point[0] = magnet_robot_point[0] * Math.Cos(-rand_angle) - magnet_robot_point[1] * Math.Sin(-rand_angle);
            magnet_robot_point[1] = magnet_robot_point[1] * Math.Cos(-rand_angle) - magnet_robot_point[0] * Math.Sin(-rand_angle);

        }

        
        void DrawRobot()
        {

           
            //!!!!!!!!!!!!!
            GL.glPushMatrix();
            //!!!!!!!!!!!!!

            //main System draw
            GL.glEnable(GL.GL_LIGHTING);
            
            GL.glRotatef(ROBOT_angle, 0, 0, 1);


            //rotate_point(ROBOT_angle);


            GL.glCallList(ROBOT_LIST);

            //end of regular show
            //!!!!!!!!!!!!!
            GL.glPopMatrix();
            //!!!!!!!!!!!!!
           
        }

       
        public bool check_distance()
        {
            if (!cought)
            {
                if (3 * r + 0.5 > Math.Sqrt(Math.Pow(move[0] - point[0], 2) + Math.Sqrt(Math.Pow(move[1] - point[1], 2))))
                    return false;
            }
            
            return true;
          
        }

        public bool check_border()
        {

            if (move[0] > size - 3 * r || -(size - 3 * r) > move[0] || move[1] > size - 3 * r || -(size - 3 * r) > move[1])
                return false;

            return true;

        }

        void new_randompoint()
        {
            if (cought)
            {
                if (move[0] > -3 + 3 * r && 3 - 3 * r > move[0] && move[1] > -3 + 3 * r && 3 - 3 * r > move[1])
                {
                    random_cube_place();
                    cought = false;

                }
            }

        }

        public float[] move = new float[3];
        public double[] point = new double[3];
        float[] squre= new float[4];
        public float[] pos = new float[4];
        public int intOptionB = 1;
        public float size = 10.0f;
        public float[] ScrollValue = new float[14];
        public float zShift = 0.0f;
        public float yShift = 0.0f;
        public float xShift = 0.0f;
        public float zAngle = 0.0f;
        public float yAngle = 0.0f;
        public float xAngle = 0.0f;
        public int intOptionC = 0;
        public double[] magnet_robot_point = new double[3];
        public double[] magnet_cube_point = new double[3];
        double[] AccumulatedRotationsTraslations = new double[16];
        public bool cought;


        void Catch()
        {
            if (2>= Math.Sqrt(Math.Pow(magnet_robot_point[0] - magnet_cube_point[0], 2) + Math.Pow(magnet_robot_point[1] - magnet_cube_point[1], 2) + Math.Pow(magnet_robot_point[2] - magnet_cube_point[2], 2)))
                cought = true;
        }
        double[] clipPlane0 = new double[4];
        double[] clipPlane1 = new double[4];
        double[] clipPlane2 = new double[4];
        double[] clipPlane3 = new double[4];

        float t_x = 0;
        float t_y = 0;
        float t_z = 0;


        void cliping_x()
        {
            clipPlane0[0] = 0;
            clipPlane0[1] = 1;
            clipPlane0[2] = 0;
            clipPlane0[3] = 0.5;

            clipPlane1[0] = 0;
            clipPlane1[1] = -1;
            clipPlane1[2] = 0;
            clipPlane1[3] = 0.5;

            clipPlane2[0] = 0;
            clipPlane2[1] = 0;
            clipPlane2[2] = 1;
            clipPlane2[3] = 0;

            clipPlane3[0] = 0;
            clipPlane3[1] = 0;
            clipPlane3[2] = -1;
            clipPlane3[3] = 1;

            GL.glClipPlane(GL.GL_CLIP_PLANE0, clipPlane0);
            GL.glClipPlane(GL.GL_CLIP_PLANE1, clipPlane1);
            GL.glClipPlane(GL.GL_CLIP_PLANE2, clipPlane2);
            GL.glClipPlane(GL.GL_CLIP_PLANE3, clipPlane3);

            GL.glEnable(GL.GL_CLIP_PLANE0);
            GL.glEnable(GL.GL_CLIP_PLANE1);
            GL.glEnable(GL.GL_CLIP_PLANE2);
            GL.glEnable(GL.GL_CLIP_PLANE3);
        }
        void cliping_y()
        {
            clipPlane0[0] = 1;
            clipPlane0[1] = 0;
            clipPlane0[2] = 0;
            clipPlane0[3] = 0.5;

            clipPlane1[0] = -1;
            clipPlane1[1] = 0;
            clipPlane1[2] = 0;
            clipPlane1[3] = 0.5;

            clipPlane2[0] = 0;
            clipPlane2[1] = 0;
            clipPlane2[2] = 1;
            clipPlane2[3] = 0;

            clipPlane3[0] = 0;
            clipPlane3[1] = 0;
            clipPlane3[2] = -1;
            clipPlane3[3] = 1;

            GL.glClipPlane(GL.GL_CLIP_PLANE0, clipPlane0);
            GL.glClipPlane(GL.GL_CLIP_PLANE1, clipPlane1);
            GL.glClipPlane(GL.GL_CLIP_PLANE2, clipPlane2);
            GL.glClipPlane(GL.GL_CLIP_PLANE3, clipPlane3);

            GL.glEnable(GL.GL_CLIP_PLANE0);
            GL.glEnable(GL.GL_CLIP_PLANE1);
            GL.glEnable(GL.GL_CLIP_PLANE2);
            GL.glEnable(GL.GL_CLIP_PLANE3);
        }
        void cliping_z()
        {
   
            //for (i = 0; i < 4; i++)
            //    clipPlane0[i] = intOptionA * ScrollValue[i];

            clipPlane0[0] = 0;
            clipPlane0[1] = 1;
            clipPlane0[2] = 0;
            clipPlane0[3] = 0.5;

            clipPlane1[0] = 0;
            clipPlane1[1] = -1;
            clipPlane1[2] = 0;
            clipPlane1[3] = 0.5;

            clipPlane2[0] = 1;
            clipPlane2[1] = 0;
            clipPlane2[2] = 0;
            clipPlane2[3] = 0.5;

            clipPlane3[0] = -1;
            clipPlane3[1] = 0;
            clipPlane3[2] = 0;
            clipPlane3[3] = 0.5;

            GL.glClipPlane(GL.GL_CLIP_PLANE0, clipPlane0);
            GL.glClipPlane(GL.GL_CLIP_PLANE1, clipPlane1);
            GL.glClipPlane(GL.GL_CLIP_PLANE2, clipPlane2);
            GL.glClipPlane(GL.GL_CLIP_PLANE3, clipPlane3);

            GL.glEnable(GL.GL_CLIP_PLANE0);
            GL.glEnable(GL.GL_CLIP_PLANE1);
            GL.glEnable(GL.GL_CLIP_PLANE2);
            GL.glEnable(GL.GL_CLIP_PLANE3);
        }

        void End_cliping()
        {
            GL.glDisable(GL.GL_CLIP_PLANE0);
            GL.glDisable(GL.GL_CLIP_PLANE1);
            GL.glDisable(GL.GL_CLIP_PLANE2);
            GL.glDisable(GL.GL_CLIP_PLANE3);
        }

        public void Draw()
        {
            GL.glLoadIdentity();
            Catch();
            CreateRobotList();
            CreateRobotListforShade();
            GL.glLoadIdentity();

            //Shadows
            pos[0] = ScrollValue[10];
            pos[1] = ScrollValue[11];
            pos[2] = ScrollValue[12];
            pos[3] = 1.0f;

            magnet_robot_point[0] = 0;
            magnet_robot_point[1] = 0;
            magnet_robot_point[2] = 0;

            //ground[0, 2] = ground[1, 2] = ground[2, 2] = ScrollValue[9];
            // wall[0, 1] = wall[1, 1] = wall[2, 1] = ScrollValue[13];
            //Shadows

            if (m_uint_DC == 0 || m_uint_RC == 0)
                return;
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //                                                           see InitializeGL also
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT );

            GL.glLoadIdentity();

            // not trivial
            double[] ModelVievMatrixBeforeSpecificTransforms = new double[16];
            double[] CurrentRotationTraslation = new double[16];

            GLU.gluLookAt(ScrollValue[0], ScrollValue[1], ScrollValue[2],
                       ScrollValue[3], ScrollValue[4], ScrollValue[5],
                       ScrollValue[6], ScrollValue[7], ScrollValue[8]);

            GL.glTranslatef(0.0f, 0.0f, 1.0f);
  
            //save current ModelView Matrix values
            //in ModelVievMatrixBeforeSpecificTransforms array
            //ModelView Matrix ========>>>>>> ModelVievMatrixBeforeSpecificTransforms
            GL.glGetDoublev(GL.GL_MODELVIEW_MATRIX, ModelVievMatrixBeforeSpecificTransforms);
            //ModelView Matrix was saved, so
            GL.glLoadIdentity(); // make it identity matrix

            //make transformation in accordance to KeyCode
            float delta;
            if (intOptionC != 0)
            {
                delta = 5.0f * Math.Abs(intOptionC) / intOptionC; // signed 5

                switch (Math.Abs(intOptionC))
                {
                    case 1:
                        GL.glRotatef(delta, 1, 0, 0);
                        break;
                    case 2:
                        GL.glRotatef(delta, 0, 1, 0);
                        break;
                    case 3:
                        GL.glRotatef(delta, 0, 0, 1);
                        break;
                    case 4:
                        GL.glTranslatef(delta / 20, 0, 0);
                        break;
                    case 5:
                        GL.glTranslatef(0, delta / 20, 0);
                        break;
                    case 6:
                         GL.glTranslatef(0, 0, delta / 20);
                     //   GL.glTranslatef(0, 0, ROBOT_angle);
                        break;
                }

            }
            //as result - the ModelView Matrix now is pure representation
            //of KeyCode transform and only it !!!

            //save current ModelView Matrix values
            //in CurrentRotationTraslation array
            //ModelView Matrix =======>>>>>>> CurrentRotationTraslation
            GL.glGetDoublev(GL.GL_MODELVIEW_MATRIX, CurrentRotationTraslation);

            //The GL.glLoadMatrix function replaces the current matrix with
            //the one specified in its argument.
            //The current matrix is the
            //projection matrix, modelview matrix, or texture matrix,
            //determined by the current matrix mode (now is ModelView mode)
            GL.glLoadMatrixd(AccumulatedRotationsTraslations); //Global Matrix

            //The GL.glMultMatrix function multiplies the current matrix by
            //the one specified in its argument.
            //That is, if M is the current matrix and T is the matrix passed to
            //GL.glMultMatrix, then M is replaced with M • T
            GL.glMultMatrixd(CurrentRotationTraslation);

            //save the matrix product in AccumulatedRotationsTraslations
            GL.glGetDoublev(GL.GL_MODELVIEW_MATRIX, AccumulatedRotationsTraslations);

            //replace ModelViev Matrix with stored ModelVievMatrixBeforeSpecificTransforms
            GL.glLoadMatrixd(ModelVievMatrixBeforeSpecificTransforms);
            //multiply it by KeyCode defined AccumulatedRotationsTraslations matrix
            GL.glMultMatrixd(AccumulatedRotationsTraslations);

           

            magnet_robot_point[2] += r * 1.2;

            double rand_SHOULDER_angle = SHOULDER_angle * Math.PI / 180;
            double rand_ROBOT_angle = ROBOT_angle * Math.PI / 180;
            double rand_ARM_angle = ARM_angle * Math.PI / 180;

            magnet_robot_point[0] += (SHOULDER_length) * Math.Sin(rand_SHOULDER_angle) * Math.Cos(-Math.PI / 2 + rand_ROBOT_angle);
            magnet_robot_point[1] += (SHOULDER_length) * Math.Sin(rand_SHOULDER_angle) * Math.Sin(-Math.PI / 2 + rand_ROBOT_angle);
            magnet_robot_point[2] += (SHOULDER_length) * Math.Cos(rand_SHOULDER_angle);


            magnet_robot_point[0] += (ARM_length) * Math.Sin(rand_ARM_angle) * Math.Cos(-Math.PI / 2 + rand_ROBOT_angle);
            magnet_robot_point[1] += (ARM_length) * Math.Sin(rand_ARM_angle) * Math.Sin(-Math.PI / 2 + rand_ROBOT_angle);
            magnet_robot_point[2] += (ARM_length) * Math.Cos(rand_ARM_angle);

            new_randompoint();

            GL.glTranslatef(0.0f, 0.0f, ground[0, 2] - 9.0f);
            //GL.glTranslatef(0.0f, 0.0f, 1);
            DrawReflection();
            DrawFloor();
            //GL.glTranslatef(0.0f, 0.0f, -1);
            GL.glTranslatef(0.0f, 0.0f, -(ground[0, 2] - 9.0f));

            GL.glLightfv(GL.GL_LIGHT0, GL.GL_POSITION, pos);
            DrawTexturedCube();

            DrawLightSource();

            GL.glTranslatef(0.0f, 0.0f, ground[0, 2] - 9.0f);

            
            //GL.glEnable(GL.GL_BLEND);
          //  DrawBlendFloor();


            if (!cought)
            {

                GL.glTranslated(point[0], point[1], 0);

                pos[0] -=(float)point[0];
                pos[1] -= (float)point[1];

                c = 'c';

                DrawCube();
                //DrawAxes();
                h = 0;
                DrawGraoundShadows();

              //  h = size;
                DrawWallShadows(0, wallC);
                DrawWallShadows(90, wall2C);
                DrawWallShadows(180, wall3C);
                DrawWallShadows(270, wall4C);

                pos[0] += (float)point[0];
                pos[1] += (float)point[1];

                GL.glTranslated(-point[0], -point[1], 0);
            }
            GL.glTranslatef(move[0], move[1], 0);
            magnet_robot_point[0] += move[0];
            magnet_robot_point[1] += move[1];


            pos[0] -= move[0];
            pos[1] -= move[1];
            pos[2] -= move[2];

            c = 'r';

            DrawRobot();

            if (!cought)
            {

                h = 1.01f;

                GL.glTranslatef(-move[0], -move[1], 0);
                GL.glTranslated(point[0], point[1], 0);

                cliping_z();

                GL.glTranslated(-point[0], -point[1], 0);
                GL.glTranslatef(move[0], move[1], 0);

                //pos[2] -= 1.01f;
                ground[0, 2] += 1.01f;
                ground[1, 2] += 1.01f;
                ground[2, 2] += 1.01f;

                //GL.glTranslatef(0, 0, h);
                DrawGraoundShadows();

                ground[0, 2] -= 1.01f;
                ground[1, 2] -= 1.01f;
                ground[2, 2] -= 1.01f;

                End_cliping();


                GL.glTranslatef(-move[0], -move[1], 0);
                GL.glTranslated(point[0], point[1], 0);

                       
                cliping_y();


                GL.glTranslated(-point[0], -point[1], 0);
                GL.glTranslatef(move[0], move[1], 0);


                DrawWallShadows(0, cubeW);
                DrawWallShadows(180, cubeW3);

                End_cliping();



                GL.glTranslatef(-move[0], -move[1], 0);
                GL.glTranslated(point[0], point[1], 0);

                cliping_x();


                GL.glTranslated(-point[0], -point[1], 0);
                GL.glTranslatef(move[0], move[1], 0);

                DrawWallShadows(270, cubeW2);
                DrawWallShadows(90, cubeW4);

                End_cliping();


            }

            h = 0;

            DrawGraoundShadows();
            h = size;
            DrawWallShadows(0, wall);
            DrawWallShadows(90, wall2);
            DrawWallShadows(180, wall3);
            DrawWallShadows(270, wall4);

            pos[0] += move[0];
            pos[1] += move[1];
            pos[2] += move[2];


            GL.glTranslatef(-move[0], -move[1], 0);


            if (!cought)
            {

                GL.glTranslated(point[0], point[1], 0);

                pos[0] -= (float)point[0];
                pos[1] -= (float)point[1];

                c = 'c';

                
                //DrawAxes();
                h = 0;
                DrawGraoundShadows();

                //  h = size;
                DrawWallShadows(0, wallC);
                DrawWallShadows(90, wall2C);
                DrawWallShadows(180, wall3C);
                DrawWallShadows(270, wall4C);

                pos[0] += (float)point[0];
                pos[1] += (float)point[1];

                GL.glTranslated(-point[0], -point[1], 0);
            }

            //DrawReflection();
            GL.glPopMatrix();

            GL.glFlush();

            WGL.wglSwapBuffers(m_uint_DC);

        }

        protected virtual void InitializeGL()
        {
            m_uint_HWND = (uint)p.Handle.ToInt32();
            m_uint_DC = WGL.GetDC(m_uint_HWND);

            // Not doing the following WGL.wglSwapBuffers() on the DC will
            // result in a failure to subsequently create the RC.
            WGL.wglSwapBuffers(m_uint_DC);

            WGL.PIXELFORMATDESCRIPTOR pfd = new WGL.PIXELFORMATDESCRIPTOR();
            WGL.ZeroPixelDescriptor(ref pfd);
            pfd.nVersion = 1;
            pfd.dwFlags = (WGL.PFD_DRAW_TO_WINDOW | WGL.PFD_SUPPORT_OPENGL | WGL.PFD_DOUBLEBUFFER);
            pfd.iPixelType = (byte)(WGL.PFD_TYPE_RGBA);
            pfd.cColorBits = 32;
            pfd.cDepthBits = 32;
            pfd.iLayerType = (byte)(WGL.PFD_MAIN_PLANE);
            
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            
            //for Stencil support 
            
            pfd.cStencilBits = 32;

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            int pixelFormatIndex = 0;
            pixelFormatIndex = WGL.ChoosePixelFormat(m_uint_DC, ref pfd);
            if (pixelFormatIndex == 0)
            {
                MessageBox.Show("Unable to retrieve pixel format");
                return;
            }

            if (WGL.SetPixelFormat(m_uint_DC, pixelFormatIndex, ref pfd) == 0)
            {
                MessageBox.Show("Unable to set pixel format");
                return;
            }
            //Create rendering context
            m_uint_RC = WGL.wglCreateContext(m_uint_DC);
            if (m_uint_RC == 0)
            {
                MessageBox.Show("Unable to get rendering context");
                return;
            }
            if (WGL.wglMakeCurrent(m_uint_DC, m_uint_RC) == 0)
            {
                MessageBox.Show("Unable to make rendering context current");
                return;
            }


            initRenderingGL();
        }

        public void OnResize()
        {
            Width = p.Width;
            Height = p.Height;
            GL.glViewport(0, 0, Width, Height);
            Draw();
        }

        protected virtual void initRenderingGL()
        {
            if (m_uint_DC == 0 || m_uint_RC == 0)
                return;
            if (this.Width == 0 || this.Height == 0)
                return;

            GL.glShadeModel(GL.GL_SMOOTH);
            GL.glClearColor(0.0f, 0.0f, 0.0f, 0.5f);
            GL.glClearDepth(1.0f);
          

            GL.glEnable(GL.GL_LIGHT0);
            GL.glEnable(GL.GL_COLOR_MATERIAL);
            GL.glColorMaterial(GL.GL_FRONT_AND_BACK, GL.GL_AMBIENT_AND_DIFFUSE);

            GL.glEnable(GL.GL_DEPTH_TEST);
            GL.glDepthFunc(GL.GL_LEQUAL);
            GL.glHint(GL.GL_PERSPECTIVE_CORRECTION_Hint, GL.GL_NICEST);	


            GL.glViewport(0, 0, this.Width, this.Height);
            GL.glMatrixMode(GL.GL_PROJECTION);
            GL.glLoadIdentity();


            //! TEXTURE 1a 
            GL.glEnable(GL.GL_COLOR_MATERIAL);
            float[] emis = { 0.3f, 0.3f, 0.3f, 1 };
            GL.glMaterialfv(GL.GL_FRONT_AND_BACK, GL.GL_EMISSION, emis);
            //! TEXTURE 1a 

            //nice 3D
            GLU.gluPerspective(45.0, 1.0, 0.4, 100.0);


            GL.glMatrixMode(GL.GL_MODELVIEW);
            GL.glLoadIdentity();

            //save the current MODELVIEW Matrix (now it is Identity)
            GL.glGetDoublev(GL.GL_MODELVIEW_MATRIX, AccumulatedRotationsTraslations);

            //! TEXTURE 1a 
            GenerateTextures();
            //! TEXTURE 1b 
        }

        public float ARM_angle;
        public float SHOULDER_angle;
        public float ROBOT_angle;
        public float alpha;




        uint ROBOT_LIST, ARM_LIST, SHOULDER_LIST;
        public float r;

        void PrepareLists()
        {
            float ARM_length, SHOULDER_length;
            ARM_length = 2;
            ARM_angle = -45;
            SHOULDER_length = 2.5f;
            SHOULDER_angle = 10;
            ROBOT_angle = 45;
            r = 0.3f;
            //r = 0.5f;

            ROBOT_LIST = GL.glGenLists(3);
            ARM_LIST = ROBOT_LIST + 1;
            SHOULDER_LIST = ROBOT_LIST + 2;

            GL.glPushMatrix();
            GL.glNewList(ARM_LIST, GL.GL_COMPILE);
            //cone
            GL.glColor3f(1, 1, 1);
            GLU.gluCylinder(obj, r * 0.7, r * 0.7, ARM_length, 20, 20);
            GL.glTranslated(0, 0, ARM_length);
           
            //internal disk
            GL.glColor3f(1, 1, 1);
            GLU.gluDisk(obj, 0, r * 0.5, 20, 20);
            //external disk
            GL.glColor3f(0, 0, 0.5f);
            GLU.gluDisk(obj, r * 0.5, r * 2, 20, 20);
            GL.glEndList();
            GL.glPopMatrix();

            GL.glPushMatrix();
            GL.glNewList(SHOULDER_LIST, GL.GL_COMPILE);
            GL.glColor3f(1, 1, 1);
            GLU.gluCylinder(obj, r, r, SHOULDER_length, 20, 20);          
            GL.glTranslated(0, 0, SHOULDER_length);

            GL.glColor3f(0, 0, 0.5f);
            GLU.gluSphere(obj, r * 1.2, 20, 20);
            GL.glEndList();
            GL.glPopMatrix();

            //CreateRobotList();
        }

        public void CreateRobotList()
        {

            GL.glPushMatrix();
            //
            // hierarchical list
            //
            GL.glNewList(ROBOT_LIST, GL.GL_COMPILE);

            // BASE : no rotations!!! Angle will be implemented in the CALL routine
            //                   before call to CreateRobotList()
            GL.glColor3f(0, 0, 0.5f);
            GLU.gluCylinder(obj, 3 * r, 3 * r, r * 1.2, 40, 20);
            GL.glTranslated(0, 0, r * 1.2);
            GLU.gluDisk(obj, 0, 3 * r, 40, 20);
            GL.glColor3f(0, 0, 1);
            GLU.gluSphere(obj, r * 1.2, 20, 20);
            // end base

            // transformations
            GL.glRotatef(SHOULDER_angle, 1, 0, 0);

            // call SHOULDER 
            GL.glCallList(SHOULDER_LIST);

            // transformations
            //no need in glTranslated 0, 0, SHOULDER_length
            //it is located properly now !!!
            GL.glRotatef(ARM_angle, 1, 0, 0);


            // call ARM  
            GL.glCallList(ARM_LIST);

            if (cought)
                DrawCube();

            GL.glEndList(); 
            GL.glPopMatrix();

            GoBack();

        }


        uint ROBOT_LIST_FOR_SHADE, ARM_LIST_FOR_SHADE, SHOULDER_LIST_FOR_SHADE;
        float ARM_length, SHOULDER_length;
        void PrepareListsforShade()
        {
            ARM_length = 2;
            ARM_angle = -45;
            SHOULDER_length = 2.5f;
            SHOULDER_angle = 10;
            ROBOT_angle = 45;
            r = 0.3f;
            //r = 0.5f;

            ROBOT_LIST_FOR_SHADE = GL.glGenLists(3);
            ARM_LIST_FOR_SHADE = ROBOT_LIST_FOR_SHADE + 1;
            SHOULDER_LIST_FOR_SHADE = ROBOT_LIST_FOR_SHADE + 2;

            GL.glPushMatrix();
            GL.glNewList(ARM_LIST_FOR_SHADE, GL.GL_COMPILE);
            //cone
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluCylinder(obj, r * 0.7, r * 0.7, ARM_length, 20, 20);
            GL.glTranslated(0, 0, ARM_length);
            //internal disk
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluDisk(obj, 0, r * 0.5, 20, 20);
            //external disk
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluDisk(obj, r * 0.5, r * 2, 20, 20);
            GL.glEndList();
            GL.glPopMatrix();

            GL.glPushMatrix();
            GL.glNewList(SHOULDER_LIST_FOR_SHADE, GL.GL_COMPILE);
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluCylinder(obj, r, r, SHOULDER_length, 20, 20);
            GL.glTranslated(0, 0, SHOULDER_length);
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluSphere(obj, r * 1.2, 20, 20);
            GL.glEndList();
            GL.glPopMatrix();

            //CreateRobotListforShade();
        }

        public void CreateRobotListforShade()
        {

            GL.glPushMatrix();
            //
            // hierarchical list
            //
            GL.glNewList(ROBOT_LIST_FOR_SHADE, GL.GL_COMPILE);

            // BASE : no rotations!!! Angle will be implemented in the CALL routine
            //                   before call to CreateRobotList()
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluCylinder(obj, 3 * r, 3 * r, r * 1.2, 40, 20);
            GL.glTranslated(0, 0, r * 1.2);
            GLU.gluDisk(obj, 0, 3 * r, 40, 20);
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLU.gluSphere(obj, r * 1.2, 20, 20);
            // end base

            // transformations
            GL.glRotatef(SHOULDER_angle, 1, 0, 0);
            
            // call SHOULDER 
            GL.glCallList(SHOULDER_LIST_FOR_SHADE);


            // transformations
            //no need in glTranslated 0, 0, SHOULDER_length
            //it is located properly now !!!
            GL.glRotatef(ARM_angle, 1, 0, 0);

            // call ARM  
            GL.glCallList(ARM_LIST_FOR_SHADE);

            if (cought)
                DrawshadeCube();

            GL.glEndList();
            GL.glPopMatrix();

            GoBack();
        }

        void GoBack() 
        {
            GL.glTranslated(0, 0, -ARM_length);
            GL.glRotatef(-ARM_angle, 1, 0, 0);
            GL.glTranslated(0, 0, -SHOULDER_length);
            GL.glRotatef(-SHOULDER_angle, 1, 0, 0);
            GL.glTranslated(0, 0, -r * 1.2);
            GL.glRotatef(-ROBOT_angle, 0, 0, 1);
        }

        //! TEXTURE b
        public uint[] Textures = new uint[6];

        void GenerateTextures()
        {
            GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);
            GL.glGenTextures(6, Textures);
            string[] imagesName ={ "front.bmp","back.bmp",
                                    "left.bmp","right.bmp","top.bmp","bottom.bmp",};
            for (int i = 0; i < 6; i++)
            {
                Bitmap image = new Bitmap(imagesName[i]);
                image.RotateFlip(RotateFlipType.RotateNoneFlipY); //Y axis in Windows is directed downwards, while in OpenGL-upwards
                System.Drawing.Imaging.BitmapData bitmapdata;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

                bitmapdata = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[i]);
                //2D for XYZ
                GL.glTexImage2D(GL.GL_TEXTURE_2D, 0, (int)GL.GL_RGB8, image.Width, image.Height,
                                                              0, GL.GL_BGR_EXT, GL.GL_UNSIGNED_byte, bitmapdata.Scan0);
                GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);
                GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);

                image.UnlockBits(bitmapdata);
                image.Dispose();
            }
        }
        //! TEXTURE CUBE b
        //Draws our textured cube, VERY simple.  Notice that the faces are constructed
        //in a counter-clockwise order.  If they were done in a clockwise order you would
        //have to use the glFrontFace() function.  
        void DrawTexturedCube()
        {
              
            GL.glPushMatrix();

            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glEnable(GL.GL_TEXTURE_2D);

            

            // front
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[4]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, -size, size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(size, -size, size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, size, size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, size, size);
            GL.glEnd();
            // back 
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, -size, -size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(size, -size, -size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, size, -size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, size, -size);
            GL.glEnd();

            //GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            //GL.glBegin(GL.GL_QUADS);
            //GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-8, -8, -size-4);
            //GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(8, -8, -size-4);
            //GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(8, 8, -size-4);
            //GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-8, 8, -size-4);
            //GL.glEnd();
            //GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            //GL.glBegin(GL.GL_QUADS);
            //GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, -size, -size);
            //GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f( size, -size, -size);
            //GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, -size + 7, -size);
            //GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, -size + 7, -size);
            //GL.glEnd();
            //GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            //GL.glBegin(GL.GL_QUADS);
            //GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, -size + 7, -size);
            //GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(-size + 7, -size + 7, -size);
            //GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(-size + 7, size, -size);
            //GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, size, -size);
            //GL.glEnd();
            //GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            //GL.glBegin(GL.GL_QUADS);
            //GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size + 7, size, -size);
            //GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(-size + 7, size - 7, -size);
            //GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, size - 7, -size);
            //GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(size, size, -size);
            //GL.glEnd();
            //GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[5]);
            //GL.glBegin(GL.GL_QUADS);
            //GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(size, size - 7, -size);
            //GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(size - 7, size - 7, -size);
            //GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size - 7, -size + 7, -size);
            //GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(size, -size + 7, -size);
            //GL.glEnd();

            // left
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[2]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, size, -size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(-size, -size, -size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(-size, -size, size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, size, size);
            GL.glEnd();
            // right
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[3]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(size, -size, -size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(size, size, -size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, size, size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(size, -size, size);
            GL.glEnd();
            // top
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[1]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(size, size, -size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(-size, size, -size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(-size, size, size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(size, size, size);
            GL.glEnd();

            // bottom
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[0]);
            GL.glBegin(GL.GL_QUADS);
            GL.glTexCoord2f(0.0f, 0.0f); GL.glVertex3f(-size, -size, -size);
            GL.glTexCoord2f(1.0f, 0.0f); GL.glVertex3f(size, -size, -size);
            GL.glTexCoord2f(1.0f, 1.0f); GL.glVertex3f(size, -size, size);
            GL.glTexCoord2f(0.0f, 1.0f); GL.glVertex3f(-size, -size, size);
            GL.glEnd();
            GL.glDisable(GL.GL_TEXTURE_2D);

        }
        //! TEXTURE CUBE e

    }


}


    





