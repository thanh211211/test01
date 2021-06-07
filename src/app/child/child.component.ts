import {
  Component,
  DoCheck,
  Input,
  OnChanges,
  OnInit,
  SimpleChanges,
} from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
})
export class ChildComponent implements OnInit, OnChanges, DoCheck {
  @Input()
  countChild: any;

  constructor() {
    console.log('Constructor Child');
  }
  ngDoCheck(): void {
    console.log('DoCheck: ' + this.countChild);
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('OnChange: ' + JSON.stringify(changes));
  }

  ngOnInit(): void {
    console.log('OnInit: Child');
  }

  increment() {
    this.countChild++;
  }
}
