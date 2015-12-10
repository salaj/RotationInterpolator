﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Media3D;

namespace MotionInterpolation
{
    public partial class MainWindow : INotifyPropertyChanged
    {
        private int animationTime;
        public int AnimationTime
        {
            get { return animationTime; }
            set
            {
                if (value != animationTime)
                {
                    animationTime = value;
                    OnPropertyChanged("AnimationTime");
                }
            }
        }

        private bool lerpActivated;
        public bool LERPActivated
        {
            get { return lerpActivated; }
            set
            {
                if (value != lerpActivated)
                {
                    lerpActivated = value;
                    OnPropertyChanged("LERPActivated");
                }
            }
        }

        private bool slerpActivated;
        public bool SLERPActivated
        {
            get { return slerpActivated; }
            set
            {
                if (value != slerpActivated)
                {
                    slerpActivated = value;
                    OnPropertyChanged("SLERPActivated");
                }
            }
        }

        private int framesCount;
        public int FramesCount
        {
            get { return framesCount; }
            set
            {
                if (value != framesCount)
                {
                    framesCount = value;
                    OnPropertyChanged("FramesCount");
                }
            }
        }

        private double startQuaternionX;
        public double StartQuaternionX
        {
            get { return startQuaternionX; }
            set
            {
                if (value != startQuaternionX)
                {
                    startQuaternionX = value;
                    OnPropertyChanged("StartQuaternionX");
                }
            }
        }

        private double startQuaternionY;
        public double StartQuaternionY
        {
            get { return startQuaternionY; }
            set
            {
                if (value != startQuaternionY)
                {
                    startQuaternionY = value;
                    OnPropertyChanged("StartQuaternionY");
                }
            }
        }

        private double startQuaternionZ;
        public double StartQuaternionZ
        {
            get { return startQuaternionZ; }
            set
            {
                if (value != startQuaternionZ)
                {
                    startQuaternionZ = value;
                    OnPropertyChanged("StartQuaternionZ");
                }
            }
        }

        private double startQuaternionW;
        public double StartQuaternionW
        {
            get { return startQuaternionW; }
            set
            {
                if (value != startQuaternionW)
                {
                    startQuaternionW = value;
                    OnPropertyChanged("StartQuaternionW");
                }
            }
        }

        private double startAngleR;
        public double StartAngleR
        {
            get { return startAngleR; }
            set
            {
                if (value != startAngleR)
                {
                    startAngleR = value;
                    OnPropertyChanged("StartAngleR");
                }
            }
        }

        private double startAngleP;
        public double StartAngleP
        {
            get { return startAngleP; }
            set
            {
                if (value != startAngleP)
                {
                    startAngleP = value;
                    OnPropertyChanged("StartAngleP");
                }
            }
        }

        private double startAngleY;
        public double StartAngleY
        {
            get { return startAngleY; }
            set
            {
                if (value != startAngleY)
                {
                    startAngleY = value;
                    OnPropertyChanged("StartAngleY");
                }
            }
        }

        private double startPositionX;
        public double StartPositionX
        {
            get { return startPositionX; }
            set
            {
                if (value != startPositionX)
                {
                    startPositionX = value;
                    OnPropertyChanged("StartPositionX");
                }
            }
        }

        private double startPositionY;
        public double StartPositionY
        {
            get { return startPositionY; }
            set
            {
                if (value != startPositionY)
                {
                    startPositionY = value;
                    OnPropertyChanged("StartPositionY");
                }
            }
        }

        private double startPositionZ;
        public double StartPositionZ
        {
            get { return startPositionZ; }
            set
            {
                if (value != startPositionZ)
                {
                    startPositionZ = value;
                    OnPropertyChanged("StartPositionZ");
                }
            }
        }

        private double endQuaternionX;
        public double EndQuaternionX
        {
            get { return endQuaternionX; }
            set
            {
                if (value != endQuaternionX)
                {
                    endQuaternionX = value;
                    OnPropertyChanged("EndQuaternionX");
                }
            }
        }

        private double endQuaternionY;
        public double EndQuaternionY
        {
            get { return endQuaternionY; }
            set
            {
                if (value != endQuaternionY)
                {
                    endQuaternionY = value;
                    OnPropertyChanged("EndQuaternionY");
                }
            }
        }

        private double endQuaternionZ;
        public double EndQuaternionZ
        {
            get { return endQuaternionZ; }
            set
            {
                if (value != endQuaternionZ)
                {
                    endQuaternionZ = value;
                    OnPropertyChanged("EndQuaternionZ");
                }
            }
        }

        private double endQuaternionW;
        public double EndQuaternionW
        {
            get { return endQuaternionW; }
            set
            {
                if (value != endQuaternionW)
                {
                    endQuaternionW = value;
                    OnPropertyChanged("EndQuaternionW");
                }
            }
        }


        private double endAngleR;
        public double EndAngleR
        {
            get { return endAngleR; }
            set
            {
                if (value != endAngleR)
                {
                    endAngleR = value;
                    OnPropertyChanged("EndAngleR");
                }
            }
        }

        private double endAngleP;
        public double EndAngleP
        {
            get { return endAngleP; }
            set
            {
                if (value != endAngleP)
                {
                    endAngleP = value;
                    OnPropertyChanged("EndAngleP");
                }
            }
        }

        private double endAngleY;
        public double EndAngleY
        {
            get { return endAngleY; }
            set
            {
                if (value != endAngleY)
                {
                    endAngleY = value;
                    OnPropertyChanged("EndAngleY");
                }
            }
        }

        private double endPositionX;
        public double EndPositionX
        {
            get { return endPositionX; }
            set
            {
                if (value != endPositionX)
                {
                    endPositionX = value;
                    OnPropertyChanged("EndPositionX");
                }
            }
        }

        private double endPositionY;
        public double EndPositionY
        {
            get { return endPositionY; }
            set
            {
                if (value != endPositionY)
                {
                    endPositionY = value;
                    OnPropertyChanged("EndPositionY");
                }
            }
        }

        private double endPositionZ;
        public double EndPositionZ
        {
            get { return endPositionZ; }
            set
            {
                if (value != endPositionZ)
                {
                    endPositionZ = value;
                    OnPropertyChanged("EndPositionZ");
                }
            }
        }

        private double framesDisplayed;
        public double FramesDisplayed
        {
            get { return framesDisplayed; }
            set
            {
                if (value != framesDisplayed)
                {
                    framesDisplayed = value;
                    OnPropertyChanged("FramesDisplayed");
                }
            }
        }

        private void InitializeVariables()
        {
            AnimationTime = 4000;
            LERPActivated = true;
            SLERPActivated = false;
            FramesCount = 30;

            StartAngleR = 30;
            StartAngleP = 0;
            StartAngleY = 0;
            StartPositionX = 5;
            StartPositionY = 0;
            StartPositionZ = 0;

            EndAngleR = 0;
            EndAngleP = 60;
            EndAngleY = 0;
            EndPositionX = 0;
            EndPositionY = 0;
            EndPositionZ = 0;

            buttonsFlags = new bool[3]{ false, false, false };
        }
    }
}
