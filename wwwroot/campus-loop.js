window.campusLoop = {
    openDialog(dialog) {
        dialog.showModal();
        document.body.style.overflow = 'hidden';
        dialog.addEventListener('cancel', event => event.preventDefault(), { once: true });
    },
    closeDialog(dialog) {
        dialog.close();
        document.body.style.overflow = '';
    }
};
