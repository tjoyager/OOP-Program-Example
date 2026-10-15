using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentInterface;

public class Environment
{
    private List<DrawingObject> _objs;

    public Environment() { 
        _objs = new List<DrawingObject>();
    }

    public void AddDrawingObject(DrawingObject obj)
    {
        _objs.Add(obj);
    }
    public void DrawPicture()
    {
        foreach (DrawingObject obj in _objs)
        {
            obj.Render();
        }
    }

    public void AnimatePicture()
    {
        foreach (DrawingObject obj in _objs)
        {
            if (obj is IMovingObject)
            {
                IMovingObject moveObj = (IMovingObject)obj;

                moveObj.Move();
            }
        }
    }
}
