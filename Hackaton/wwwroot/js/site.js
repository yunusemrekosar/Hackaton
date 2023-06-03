// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const main = document.querySelector('header');
const reg = document.querySelector('.registerCon');
const logging = document.querySelector('.loginCon');

const registerOpen = () => {
	main.classList.add('blur');
	reg.classList.remove('hidden');
	console.log('1');
	reg.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex flex-column gap-5 " style='z-index:10'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">AD</h3>
						<input
							type="text"
							id="name" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">SOYAD</h3>
						<input
							type="text"
							id="surname" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">E-MAİL</h3>
						<input
							type="email"
							id="email" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="nav-link btn btn-dark h-75 text-white close"
							onclick="registerClose()"
							>GERİ</a
						>
						<input
							class="btn btn-light"
							type="button"
							value="KAYIT OL" />
					</div>
				</div>
			</div>
        `;
};

const registerClose = () => {
	main.classList.remove('blur');
	reg.classList.add('hidden');
	console.log('2');
	reg.innerHTML = '';
};

const loginOpen = () => {
	main.classList.add('blur');
	logging.classList.remove('hidden');
	console.log('1');
	logging.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex flex-column gap-5 " style='z-index:10'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">Username</h3>
						<input
							type="text"
							id="username" />
					</div>
					
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">E-MAİL</h3>
						<input
							type="password"
							id="password" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="nav-link btn btn-dark h-75 text-white close"
							onclick="loginClose()"
							>GERİ</a
						>
						<input
							class="btn btn-light"
							type="button"
							value="GİRİŞ YAP" />
					</div>
				</div>
			</div>
        `;
};

const loginClose = () => {
	main.classList.remove('blur');
	logging.classList.add('hidden');
	console.log('2');
	logging.innerHTML = '';
};
