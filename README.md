# red
yo yo
sd fhla







public Boolean InAirNoCollision(PictureBox tar)
        {
            if (!OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in WorldObjects)
                {
                    if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    {
                        if (tar.Location.Y < WorldFrame.Width)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X + temp1.Width, temp1.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        } 