import { Component, inject } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-roles-modal',
  standalone: true,
  imports: [],
  templateUrl: './roles-modal.component.html',
  styleUrl: './roles-modal.component.css'
})
export class RolesModalComponent {
  bsModalRef = inject(BsModalRef);
  username = '';
  title = '';
  availableRoles: string[] = [];
  selectedRoles: string[] = [];
  rolesUpdated = false;

  updateChecked(checkeValue: string){
    if(this.selectedRoles.includes(checkeValue)){
      this.selectedRoles = this.selectedRoles.filter(r => r !== checkeValue);
    } else {
      this.selectedRoles.push(checkeValue);
    }
  }

  onSelectRoles(){
    this.rolesUpdated = true;
    this.bsModalRef.hide();
  }
}
