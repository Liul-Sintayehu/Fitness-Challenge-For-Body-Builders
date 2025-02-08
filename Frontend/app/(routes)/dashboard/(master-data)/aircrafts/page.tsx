// 'use client';

// import React, { useEffect } from 'react';
// import PageNavbar, {
//   PageNavbarLeftContent,
//   PageNavbarRightContent,
// } from '@/app/_components/layout/PageNavbar';
// import AircraftTableComponent from '@/components/ui/master_data/aircraft/full';
// import Breadcrumb from '@/app/_components/ui/Breadcrumb';
// import { Plane } from 'lucide-react';
// import { useRouter } from 'next/navigation';
// import { useAuthorization } from '@/app/_hooks/useAuthorization';
// import Spinner from '@/app/_components/common/Spinner';

// const Dashboard = () => {
//   const router = useRouter();

//   const isAuthorized = useAuthorization('AircraftType-GetAll');

//   useEffect(() => {
//     if (isAuthorized === false) {
//       router.push('/dashboard/403');
//     }
//   }, [isAuthorized, router]);

//   if (isAuthorized === null) {
//     return (
//       <div className="h-screen flex items-center justify-center">
//         <Spinner />
//       </div>
//     );
//   }

//   if (!isAuthorized) {
//     return null;
//   }
//   return (
//     <>
//       <PageNavbar>
//         <PageNavbarLeftContent>
//           <div className="whitespace-nowrap flex items-center">
//             <Plane color="green" className="text-3xl" />
//             <Breadcrumb
//               breadcrumbs={[
//                 {
//                   label: 'Master Data',
//                   to: `/dashboard/aircrafts`,
//                 },
//                 {
//                   label: 'Aircraft',
//                   to: `/dashboard/aircrafts`,
//                   active: true,
//                 },
//               ]}
//             />
//           </div>
//         </PageNavbarLeftContent>

//         <PageNavbarRightContent className="pr-2"></PageNavbarRightContent>
//       </PageNavbar>
//       <div className="mx-4">
//         <AircraftTableComponent />
//       </div>
//     </>
//   );
// };

// export default Dashboard;
