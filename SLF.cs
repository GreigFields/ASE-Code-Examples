using System;
using System.Collections.Generic;
using System.Text;
/* 
 * Developed by Greig Fields 12/15/2021 to support ASE Course
 * Permission to freely destribute as long as this header is attached
 */

namespace ASE_Code_Examples
{
    class SLF
    {
        public struct Speed { public double s; }
        public struct LatLong {
            public double LAT;
            public double LONG;
        }
        public interface SpeedLimitFinder
        {
            Speed getSpeedLimit();
            void accellerate();
        }
      public enum SLFTYPE  { CAMERA, GPSMAP};
        public class FactoryClient
        {
            FactoryClient()
            {
                SpeedLimitFinder slf;
                slf = new SpeedLimitFinderFactory().getSLF(SLFTYPE.CAMERA);
                slf = new SpeedLimitFinderFactory().getSLF(SLFTYPE.GPSMAP);
                
                Speed ls = slf.getSpeedLimit();
            }
 
            public void accellerate()
            {
                return;
            }
        }
        
        public class SpeedLimitFinderFactory : SpeedLimitFinder
        {

            public SpeedLimitFinder getSLF(SLFTYPE slfType)
            {
                switch (slfType)
                {
                    case SLFTYPE.CAMERA:
                        return new CameraSignSpeed();
                    case SLFTYPE.GPSMAP:
                        return new GPSMap();
                    default:
                        return new GPSMap();
                }
                
            }
            public Speed getSpeedLimit()
            {
                return new Speed { s = -1 }; // should not be called this is just the factory
            }
            public void accellerate()
            {
                return;
            }
        }


        public class SpeedLimitLogger : SpeedLimitFinder
        {

            public Speed getSpeedLimit()
            {
                return new Speed { s = 0 };

            }

            public void accellerate()
            {
                return;
            }
        }


        public class GPSMap : SpeedLimitFinder
        {
            Speed currentspeed;
            public GPSMap()
            {
                currentspeed.s = 0;
            }
            public Speed getSpeedLimit()
            {
                // get current GEOLOC this should be in another class..
                GeoLoc gl = new GeoLoc();
                // find speed at GEOLoc
                LatLong ll = gl.getCurrentLoc();

                return gl.getSpeedAtLoc(ll);
            }
            public void accellerate()
            {
                return;
            }

        }
        public class GeoLoc
        {

            private LatLong localLATLong;

            LatLong CurrentLoc;
            public GeoLoc()
            {
                localLATLong = getCurrentLoc(); // from the device
            }
            public LatLong getCurrentLoc()
            {
                // Returns the current Lat Long
                return new LatLong { LAT = 1, LONG = 1 };
            }
            public Speed getSpeedAtLoc(LatLong latLong)
            {
                // look up speed limit based upon  latLong
                return new Speed { s = 100 };
            }
        }
        public class CameraSignSpeed : SpeedLimitFinder
        {
            Speed lastSpeedLimt;
            public CameraSignSpeed()
            {
                lastSpeedLimt.s = 0;
            }
            public Speed getSpeedLimit()
            {
                // get current GEOLOC this should be in another class..
                CameraSpeed cs = new CameraSpeed();
                // find speed at GEOLoc
                Speed LastSpeedLimit = new Speed  { s = cs.getLastSpeed()};

                return lastSpeedLimt;
            }
            public void accellerate()
            {
                return;
            }

        }

        public class CameraSpeed
        {

            private double localLastSpeed; 


            public CameraSpeed()
            {
                findLastSpeed(); // from the device
            }
            public double getLastSpeed()
            {
                // Returns the last speed seen
                return localLastSpeed;
            }
            public void findLastSpeed()
            {
                localLastSpeed = 0; // whatever came from last camera shot
            }
        }
    }
    public class SpeedController
    {
        double speed;
        SLF.SpeedLimitLogger speedLimitFinder = new SLF.SpeedLimitLogger();
        SpeedController()
        {
            speedLimitFinder = new SLF.SpeedLimitLogger();
            SLF.Speed currentSpeedLimit = speedLimitFinder.getSpeedLimit();
        }
    }
}

