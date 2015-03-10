using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.SuperHerous
{
	class SuperHeroAdapter : ISuperHero
	{
		private IFly _fly;
		private IShoot _shoot;
		private IGoThroughWall _goThroughWall;

		public SuperHeroAdapter(IFly fly, IShoot shoot, IGoThroughWall goThrouhgWall)
		{
			_fly = fly;
			_shoot = shoot;
			_goThroughWall = goThrouhgWall;
		}


		public void Shoot()
		{
			_shoot.Shoot();
		}

		public void Fly()
		{
			_fly.Fly();
		}

		public void GoThrougWall()
		{
			_goThroughWall.GoThroughWall();
		}
	}
}
