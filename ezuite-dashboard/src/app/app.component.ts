import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  searchText: string = '';
  users = [
    { firstName: 'John', lastName: 'Doe', email: 'john.doe@example.com', department: 'Sales' },
    { firstName: 'Jane', lastName: 'Smith', email: 'jane.smith@example.com', department: 'Marketing' },
    { firstName: 'Alice', lastName: 'Johnson', email: 'alice.johnson@example.com', department: 'HR' },
    { firstName: 'Bob', lastName: 'Brown', email: 'bob.brown@example.com', department: 'IT' },
  ];

  filterUsers() {
    return this.users.filter(user =>
      Object.values(user).some(value =>
        value.toString().toLowerCase().includes(this.searchText.toLowerCase())
      )
    );
  }
}


