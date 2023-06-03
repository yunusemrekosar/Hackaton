// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const main = document.querySelector('header');
const reg = document.querySelector('.registerCon');
const logging = document.querySelector('.loginCon');
const form = document.querySelector('.formCon');

const registerOpen = () => {
	main.classList.add('blur');
	reg.classList.remove('hidden');
	if (logging.innerHTML != '') {
		logging.innerHTML = '';
	}
	if (form.innerHTML != '') {
		form.innerHTML = '';
	}
	reg.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex justify-content-center flex-column gap-5 h-50 w-100 p-5  bg-dark text-white rounded-4" style='z-index:10;
				box-shadow: -27px 34px 52px -15px rgba(0,0,0,0.2);
				'>
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
							class="btn btn-light close"
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
	reg.innerHTML = '';
};

const loginOpen = () => {
	main.classList.add('blur');
	logging.classList.remove('hidden');
	if (reg.innerHTML != '') {
		reg.innerHTML = '';
	}
	if (form.innerHTML != '') {
		form.innerHTML = '';
	}
	logging.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex justify-content-center flex-column gap-5 h-50 w-100 p-5  bg-dark text-white rounded-4" style='z-index:10; box-shadow: 27px 34px 52px -15px rgba(100,100,100,0.3);'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">KULLANICI ADI</h3>
						<input
							type="text"
							id="username" />
					</div>
					
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">ŞİFRE-MAİL</h3>
						<input
							type="password"
							id="password" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="btn btn-light close"
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
	logging.innerHTML = '';
};
